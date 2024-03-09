﻿// <auto-generated />
using System;
using BadmintonApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BadmintonApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BadmintonApp.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9637),
                            Title = "Одиночный разряд"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9638),
                            Title = "Парный разряд"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9639),
                            Title = "Смешанный"
                        });
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9631),
                            Name = "Пермь",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9632),
                            Name = "Березники",
                            RegionId = 1
                        });
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9625),
                            Name = "Россия"
                        });
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9627),
                            Name = "Пермский край"
                        });
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Matches.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PlayerOneId")
                        .HasColumnType("integer");

                    b.Property<int>("PlayerTwoId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PlayerOneId");

                    b.HasIndex("PlayerTwoId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Matches.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MatchId")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("ScorePlayerOne")
                        .HasColumnType("integer");

                    b.Property<int>("ScorePlayerTwo")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Players.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateBirthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Genger")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("RankId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("RankId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Players.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Ranks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9603),
                            Title = "МСМК"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9606),
                            Title = "МС"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9609),
                            Title = "КМС"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9611),
                            Title = "1"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9613),
                            Title = "2"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9613),
                            Title = "3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9614),
                            Title = "1ю"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9618),
                            Title = "2ю"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAtUTC = new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9619),
                            Title = "3ю"
                        });
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAtUTC")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CategoryTournament", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("TournamentsId")
                        .HasColumnType("integer");

                    b.HasKey("CategoriesId", "TournamentsId");

                    b.HasIndex("TournamentsId");

                    b.ToTable("CategoryTournament");
                });

            modelBuilder.Entity("PlayerTournament", b =>
                {
                    b.Property<int>("PlayersId")
                        .HasColumnType("integer");

                    b.Property<int>("TournamentsId")
                        .HasColumnType("integer");

                    b.HasKey("PlayersId", "TournamentsId");

                    b.HasIndex("TournamentsId");

                    b.ToTable("PlayerTournament");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.City", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Location.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.Region", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Location.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Matches.Match", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Players.Player", "PlayerOne")
                        .WithMany("HomeMatches")
                        .HasForeignKey("PlayerOneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BadmintonApp.Data.Entities.Players.Player", "PlayerTwo")
                        .WithMany("AwayMatches")
                        .HasForeignKey("PlayerTwoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayerOne");

                    b.Navigation("PlayerTwo");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Matches.Set", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Matches.Match", "Match")
                        .WithMany("Sets")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Players.Player", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BadmintonApp.Data.Entities.Players.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId");

                    b.Navigation("City");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Tournament", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CategoryTournament", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BadmintonApp.Data.Entities.Tournament", null)
                        .WithMany()
                        .HasForeignKey("TournamentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerTournament", b =>
                {
                    b.HasOne("BadmintonApp.Data.Entities.Players.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BadmintonApp.Data.Entities.Tournament", null)
                        .WithMany()
                        .HasForeignKey("TournamentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.Country", b =>
                {
                    b.Navigation("Regions");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Location.Region", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Matches.Match", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("BadmintonApp.Data.Entities.Players.Player", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("HomeMatches");
                });
#pragma warning restore 612, 618
        }
    }
}
