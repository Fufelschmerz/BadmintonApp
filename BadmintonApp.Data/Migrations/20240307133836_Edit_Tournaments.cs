using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BadmintonApp.Data.Migrations
{
    public partial class Edit_Tournaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTournament_Tournaments_TournamentsId",
                table: "CategoryTournament");

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
                name: "FK_CategoryTournament_Tournaments_TournamentsId",
                table: "CategoryTournament",
                column: "TournamentsId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Tournaments_TournamentId",
                table: "Players",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTournament_Tournaments_TournamentsId",
                table: "CategoryTournament");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Tournaments_TournamentId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TournamentId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Ranks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtUTC",
                value: new DateTime(2024, 3, 6, 13, 14, 27, 829, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTournament_Tournaments_TournamentsId",
                table: "CategoryTournament",
                column: "TournamentsId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }
    }
}
