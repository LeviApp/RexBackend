using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rex.Migrations
{
    public partial class RemoveTimeStamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonCreation",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LessonUpdate",
                table: "Lessons");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "LessonChallenge", "LessonMain", "LessonNumber", "LessonSolution", "LessonTitle" },
                values: new object[] { 2, "There are two main aspects to websites. The Front End is the visual side of the webpage. It includes elements such as the paragraph, image, and color. The Front End is very important to get right. It must be laid out correctly and visually appealing. It must be user-friendly. The Back End involves all of the data that a user might need. When a user needs to see an email, the Back End works behind the scenes to get that information. It includes apis, servers, routes, and automation.", "Another pattern that RegEx accounts for is, obviously, found in the middle. RegEx isn't only for patterns at the start of a text block. At any point in the middle of a text block, RegEx can search for a pattern. Roses are red and violets are blue. Using literal characters, search for the word in the following paragraph that best describes a jpeg if you want to continue.", 2, "image", "The In-Between" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "LessonCreation",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LessonUpdate",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
