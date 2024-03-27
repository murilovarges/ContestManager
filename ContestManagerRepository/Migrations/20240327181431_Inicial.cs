using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContestManagerRepository.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", nullable: false),
                    InitialContestDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FinalContestDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InitialRegistrationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FinalRegistrationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MinimalTeamContestant = table.Column<int>(type: "int", nullable: false),
                    MaximumTeamContestant = table.Column<int>(type: "int", nullable: false),
                    MinimalTeamCoach = table.Column<int>(type: "int", nullable: false),
                    MaximumTeamCoach = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Link = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    UniversityAcronym = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Contest_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsMediumLevel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contestant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(50)", nullable: true),
                    Document = table.Column<string>(type: "varchar(50)", nullable: true),
                    UniversityRegistrationNumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    TshirtSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(50)", nullable: true),
                    UniversityId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contestant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contestant_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contestant_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamContestants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    ContestantId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamContestants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamContestants_Contestant_ContestantId",
                        column: x => x.ContestantId,
                        principalTable: "Contestant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamContestants_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contest",
                columns: new[] { "Id", "Description", "FinalContestDate", "FinalRegistrationDate", "Image", "InitialContestDate", "InitialRegistrationDate", "Link", "MaximumTeamCoach", "MaximumTeamContestant", "MinimalTeamCoach", "MinimalTeamContestant", "Name" },
                values: new object[,]
                {
                    { 1, "A maior maratona do IFSP", new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2610), null, new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2609), null, 0, 0, 0, 0, "VII InterIF 2024 - Final Piracicaba" },
                    { 2, "A maior maratona do IFSP", new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2612), new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2613), null, new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2612), null, 0, 0, 0, 0, "VI InterIF 2023 - Final Campinas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contestant_CourseId",
                table: "Contestant",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Contestant_UniversityId",
                table: "Contestant",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_UniversityId",
                table: "Course",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ContestId",
                table: "Team",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamContestants_ContestantId",
                table: "TeamContestants",
                column: "ContestantId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamContestants_TeamId",
                table: "TeamContestants",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamContestants");

            migrationBuilder.DropTable(
                name: "Contestant");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Contest");

            migrationBuilder.DropTable(
                name: "University");
        }
    }
}
