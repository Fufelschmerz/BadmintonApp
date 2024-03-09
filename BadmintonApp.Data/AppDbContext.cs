using BadmintonApp.Data.DefaultData;
using BadmintonApp.Data.DefaultData.Location;
using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Entities.Location;
using BadmintonApp.Data.Entities.Matches;
using BadmintonApp.Data.Entities.Players;
using BadmintonApp.Data.Exceptions;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace BadmintonApp.Data;

public sealed class AppDbContext : DbContext
{
	public DbSet<Tournament> Tournaments => Set<Tournament>();

	public DbSet<Category> Categories => Set<Category>();

    public DbSet<User> Users => Set<User>();

	public DbSet<Rank> Ranks => Set<Rank>();

	public DbSet<Player> Players => Set<Player>();

	public DbSet<Match> Matches => Set<Match>();

	public DbSet<Country> Countries => Set<Country>();

	public DbSet<Region> Regions => Set<Region>();

	public DbSet<City> Cities => Set<City>();

	public DbSet<Set> Sets => Set<Set>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//TODO: рефакторинг
		var ranks = new RankDefaults().GetDefaultsData();
		var countries = new CountryDefaults().GetDefaultsData();
		var regions = new RegionDefaults().GetDefaultsData();
		var cities = new CityDefaults().GetDefaultsData();
		var categories = new CategoryDefaults().GetDefaultsData();

		modelBuilder.Entity<Rank>(entity =>
		{
			entity.HasData(ranks);
		});

		modelBuilder.Entity<Country>(entity =>
		{
			entity.HasData(countries);
		});

		modelBuilder.Entity<Region>(entity =>
		{
			entity.HasData(regions);
		});

		modelBuilder.Entity<City>(entity =>
		{
			entity.HasData(cities);
		});

		modelBuilder.Entity<Category>(entity =>
		{
			entity.HasData(categories);
		});

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

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