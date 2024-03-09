using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BadmintonApp.Data.Migrations
{
    public partial class Edit_Tournaments1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Tournaments_TournamentId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TournamentId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Players");

            migrationBuilder.CreateTable(
                name: "PlayerTournament",
                columns: table => new
                {
                    PlayersId = table.Column<int>(type: "integer", nullable: false),
                    TournamentsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTournament", x => new { x.PlayersId, x.TournamentsId });
                    table.ForeignKey(
                        name: "FK_PlayerTournament_Players_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTournament_Tournaments_TournamentsId",
                        column: x => x.TournamentsId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 14, 19, 19, 107, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTournament_TournamentsId",
                table: "PlayerTournament",
                column: "TournamentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerTournament");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Players",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 7, 13, 38, 35, 410, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.CreateIndex(
                name: "IX_Players_TournamentId",
                table: "Players",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Tournaments_TournamentId",
                table: "Players",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }
    }
}
