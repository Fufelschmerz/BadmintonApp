using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Entities.Matches;
using BadmintonApp.Data.Entities.Players;
using BadmintonApp.Data.Exceptions;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace BadmintonApp.Data;

public sealed class AppDbContext : DbContext
{
	public DbSet<User> Users => Set<User>();

	public DbSet<Rank> Ranks => Set<Rank>();

	public DbSet<Player> Players => Set<Player>();

	public DbSet<Match> Matches => Set<Match>();

	public DbSet<Set> Sets => Set<Set>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//TODO: рефакторинг
		modelBuilder.Entity<Player>()
			.HasMany(x => x.HomeMatches)
			.WithOne(x => x.PlayerOne)
			.HasForeignKey(x => x.PlayerOneId)
			.HasPrincipalKey(x => x.Id);

		//TODO: рефакторинг
		modelBuilder.Entity<Player>()
			.HasMany(x => x.AwayMatches)
			.WithOne(x => x.PlayerTwo)
			.HasForeignKey(x => x.PlayerTwoId)
			.HasPrincipalKey(x => x.Id);

		//TODO: инициализировать остальные разряды
		//TODO: рефакторинг
		var ranks = new Rank[]
		{
			new Rank
			{
				Id = 1,
				Title = "КМС",
				CreatedAtUTC = DateTime.UtcNow,
			},
			new Rank
			{
				Id = 2,
				Title = "1 спортивный",
				CreatedAtUTC= DateTime.UtcNow,
			}
		};

		modelBuilder.Entity<Rank>(entity =>
		{
			entity.HasData(ranks);
		});

		base.OnModelCreating(modelBuilder);
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql(@"Host=localhost;Database=BadmintonDb;Port=5433;Username=postgres;Password=root;Persist Security Info=True;Include Error Detail=True");


		base.OnConfiguring(optionsBuilder);
	}

	public override int SaveChanges()
	{
		try
		{
			SetDates();
			return base.SaveChanges();
		}
		catch (DbUpdateException ex)
		{
			if (ex.InnerException is PostgresException pgException)
				HandleException(pgException);

			throw;
		}
	}

	private static void HandleException(PostgresException pgException)
	{
		switch (pgException.SqlState)
		{
			case PostgresErrorCodes.ForeignKeyViolation:
				throw new ForeignKeyException("Violation of the foreign key constraint");
		}
	}

	private void SetDates()
	{
		var entries = ChangeTracker
			.Entries()
			.Where(e =>
				e is { Entity: BaseEntity, State: EntityState.Added or EntityState.Modified });

		foreach (var entityEntry in entries)
		{
			if (entityEntry is { State: EntityState.Added, Entity: BaseEntity createdEntity })
				createdEntity.CreatedAtUTC = DateTime.UtcNow;

			if (entityEntry is { State: EntityState.Modified, Entity: BaseEntity updatedEntity })
				updatedEntity.UpdatedAtUTC = DateTime.UtcNow;
		}
	}
}