using BadmintonApp.Data.Entities.Players;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonApp.Data.Configurations;

internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
	public void Configure(EntityTypeBuilder<Player> builder)
	{
		builder.HasMany(x => x.HomeMatches)
			.WithOne(x => x.PlayerOne)
			.HasForeignKey(x => x.PlayerOneId)
			.HasPrincipalKey(x => x.Id);

		builder.HasMany(x => x.AwayMatches)
			.WithOne(x => x.PlayerTwo)
			.HasForeignKey(x => x.PlayerTwoId)
			.HasPrincipalKey(x => x.Id);
	}
}
