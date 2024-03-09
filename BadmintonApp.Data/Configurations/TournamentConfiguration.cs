using BadmintonApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonApp.Data.Configurations;

internal class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
{
	public void Configure(EntityTypeBuilder<Tournament> builder)
	{
		builder.HasMany(x => x.Categories)
			.WithMany(x => x.Tournaments);

		builder.HasMany(x => x.Players)
			.WithMany(x => x.Tournaments);
	}
}