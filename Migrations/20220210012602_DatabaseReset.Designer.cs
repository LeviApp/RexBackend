﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Rex.Data;

namespace Rex.Migrations
{
    [DbContext(typeof(RexContext))]
    [Migration("20220210012602_DatabaseReset")]
    partial class DatabaseReset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Rex.Models.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("LessonChallenge")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("LessonMain")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("integer");

                    b.Property<string>("LessonSolution")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("LessonTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("LessonId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            LessonId = 1,
                            LessonChallenge = "Websites are built using three main languages: HTML, CSS, and JavaScript. These three languages are usually explained by comparing them to a house. HTML is the physical brick of the house. It is the physical content which makes up the website. CSS is the paint you apply to the brick or door. It makes the content on the webpage look better. JavaScript is the doorbell of the house. Its responsibility is to produce some kind of functionality to the house. JavaScript does the same with the website.",
                            LessonMain = "Welcome to the RegEx Rex course. RegEx is a way to search for patterns in text. You can search for letters, words, and digits. You can search for a certain length of words and a lot of other patterns. In normal searches, what is being used are literal characters. Searching for 'code' is searching for the exact pattern of letters that spell out the word. In the first couple of lessons, we will be focusing on literal characters to explore different patterns that RegEx can be used for. The first pattern we will discuss is the beginning. RegEx can be used to search for a pattern at the very start of a text block. Use the search bar above to solve the lesson's challenge. Ignore the second text box for now. Using literal characters, search for the first word in the following paragraph.",
                            LessonNumber = 1,
                            LessonSolution = "Websites",
                            LessonTitle = "Beginnings"
                        },
                        new
                        {
                            LessonId = 2,
                            LessonChallenge = "There are two main aspects to websites. The Front End is the visual side of the webpage. It includes elements such as the paragraph, image, and color. The Front End is very important to get right. It must be laid out correctly and visually appealing. It must be user-friendly. The Back End involves all of the data that a user might need. When a user needs to see an email, the Back End works behind the scenes to get that information. It includes apis, servers, routes, and automation.",
                            LessonMain = "Another pattern that RegEx accounts for is, obviously, found in the middle. RegEx isn't only for patterns at the start of a text block. At any point in the middle of a text block, RegEx can search for a pattern. Roses are red and violets are blue. Using literal characters, search for the word in the following paragraph that best describes a jpeg if you want to continue.",
                            LessonNumber = 2,
                            LessonSolution = "image",
                            LessonTitle = "The In-Between"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
