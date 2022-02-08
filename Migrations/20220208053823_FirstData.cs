using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rex.Migrations
{
    public partial class FirstData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "LessonChallenge", "LessonCreation", "LessonMain", "LessonNumber", "LessonSolution", "LessonTitle", "LessonUpdate" },
                values: new object[] { 1, "Websites are built using three main languages: HTML, CSS, and JavaScript. These three languages are usually explained by comparing them to a house. HTML is the physical brick of the house. It is the physical content which makes up the website. CSS is the paint you apply to the brick or door. It makes the content on the webpage look better. JavaScript is the doorbell of the house. Its responsibility is to produce some kind of functionality to the house. JavaScript does the same with the website.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welcome to the RegEx Rex course. RegEx is a way to search for patterns in text. You can search for letters, words, and digits. You can search for a certain length of words and a lot of other patterns. In normal searches, what is being used are literal characters. Searching for 'code' is searching for the exact pattern of letters that spell out the word. In the first couple of lessons, we will be focusing on literal characters to explore different patterns that RegEx can be used for. The first pattern we will discuss is the beginning. RegEx can be used to search for a pattern at the very start of a text block. Use the search bar above to solve the lesson's challenge. Ignore the second text box for now. Using literal characters, search for the first word in the following paragraph.", 1, "Websites", "Beginnings", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1);
        }
    }
}
