using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Rex.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessonNumber = table.Column<int>(type: "integer", nullable: false),
                    LessonTitle = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LessonMain = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    LessonChallenge = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    LessonSolution = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LessonCreation = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LessonUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
