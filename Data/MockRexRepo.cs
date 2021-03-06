using System.Collections.Generic;
using Rex.Models;

namespace Rex.Data
{
    public class MockRexRepo : IRexRepo
    {
        public IEnumerable<Lesson> GetLessons()
        {
            var lessons = new List<Lesson>
            {
                new Lesson{LessonId=0, LessonNumber=1, LessonTitle="Beginnings", LessonMain="Welcome to the RegEx Rex course. RegEx is a way to search for patterns in text. You can search for letters, words, and digits. You can search for a certain length of words and a lot of other patterns. In normal searches, what is being used are literal characters. Searching for 'code' is searching for the exact pattern of letters that spell out the word. In the first couple of lessons, we will be focusing on literal characters to explore different patterns that RegEx can be used for. The first pattern we will discuss is the beginning. RegEx can be used to search for a pattern at the very start of a text block. Use the search bar above to solve the lesson's challenge. Ignore the second text box for now. Using literal characters, search for the first word in the following paragraph.", LessonChallenge="Websites are built using three main languages: HTML, CSS, and JavaScript. These three languages are usually explained by comparing them to a house. HTML is the physical brick of the house. It is the physical content which makes up the website. CSS is the paint you apply to the brick or door. It makes the content on the webpage look better. JavaScript is the doorbell of the house. Its responsibility is to produce some kind of functionality to the house. JavaScript does the same with the website.", LessonSolution="Websites"},
                new Lesson{LessonId=1, LessonNumber=2, LessonTitle="The In-Between", LessonMain="Another pattern that RegEx accounts for is, obviously, found in the middle. RegEx isn't only for patterns at the start of a text block. At any point in the middle of a text block, RegEx can search for a pattern. Roses are red and violets are blue. Using literal characters, search for the word in the following paragraph that best describes a jpeg if you want to continue.", LessonChallenge="There are two main aspects to websites. The Front End is the visual side of the webpage. It includes elements such as the paragraph, image, and color. The Front End is very important to get right. It must be laid out correctly and visually appealing. It must be user-friendly. The Back End involves all of the data that a user might need. When a user needs to see an email, the Back End works behind the scenes to get that information. It includes apis, servers, routes, and automation.", LessonSolution="image"},
                new Lesson{LessonId=2, LessonNumber=3, LessonTitle="The Finish", LessonMain="The next pattern that deals with position is the ending. RegEx can find a pattern at the end of a text block. It doesn't matter what is at the end of a text block. It could be letters, words, numbers, or other characters. Punctuation is always good to consider when searching strings. This is important for the beginning, middle, or end of a text block. Using a literal pattern, find the last word in the following paragraph, including punctuation.", LessonChallenge="While all websites will ultimately be using HTML, CSS, and JavaScript, this does not mean developers have not implemented technologies, called frameworks, to help them build websites. Frameworks can be used to build the Front End. Every framework has foundational code it implements under the hood. The three most popular frameworks for the Front End are React, Angular, and Vue. All three of these frameworks are based in the JavaScript programming language!", LessonSolution="language!"},
                new Lesson{LessonId=3, LessonNumber=4, LessonTitle="Global Flag", LessonMain="Flags are characters you add at the end of a RegEx expression that provide extra functionality. The first flag we will discuss is the global ('g') flag. A proper RegEx expression looks like this. Example 1: /website/. This example will only find the first item that matches the exact pattern. In this case, the first time the word 'website' is found in the text block. To find all items that match a given RegEx pattern, you must add the global flag at the end. Example 2: /website/g. This example will find all the items that match 'website' in the text block. In the following paragraph, find all the words that match 'framework'.", LessonChallenge="Frameworks can also be used for the Back End. A popular Back End framework is Node.js. It implements JavaScript behind the scenes. A framework that uses Python as its base computer language is Django. This framework includes a lot of out-of-th-box functionality. It even has a user-interface for admins dealing with server data. Other frameworks developers use include Laravel (PHP framework), Spring Boot (Java framework), and .NET (C# framework).", LessonSolution="Websites"}
            };
            return lessons;

        }

        public Lesson GetIndividualLesson(int id)
        {
             var lessons = new List<Lesson>
            {
                new Lesson{LessonId=0, LessonNumber=1, LessonTitle="Beginnings", LessonMain="Welcome to the RegEx Rex course. RegEx is a way to search for patterns in text. You can search for letters, words, and digits. You can search for a certain length of words and a lot of other patterns. In normal searches, what is being used are literal characters. Searching for 'code' is searching for the exact pattern of letters that spell out the word. In the first couple of lessons, we will be focusing on literal characters to explore different patterns that RegEx can be used for. The first pattern we will discuss is the beginning. RegEx can be used to search for a pattern at the very start of a text block. Use the search bar above to solve the lesson's challenge. Ignore the second text box for now. Using literal characters, search for the first word in the following paragraph.", LessonChallenge="Websites are built using three main languages: HTML, CSS, and JavaScript. These three languages are usually explained by comparing them to a house. HTML is the physical brick of the house. It is the physical content which makes up the website. CSS is the paint you apply to the brick or door. It makes the content on the webpage look better. JavaScript is the doorbell of the house. Its responsibility is to produce some kind of functionality to the house. JavaScript does the same with the website.", LessonSolution="Websites"},
                new Lesson{LessonId=1, LessonNumber=2, LessonTitle="The In-Between", LessonMain="Another pattern that RegEx accounts for is, obviously, found in the middle. RegEx isn't only for patterns at the start of a text block. At any point in the middle of a text block, RegEx can search for a pattern. Roses are red and violets are blue. Using literal characters, search for the word in the following paragraph that best describes a jpeg if you want to continue.", LessonChallenge="There are two main aspects to websites. The Front End is the visual side of the webpage. It includes elements such as the paragraph, image, and color. The Front End is very important to get right. It must be laid out correctly and visually appealing. It must be user-friendly. The Back End involves all of the data that a user might need. When a user needs to see an email, the Back End works behind the scenes to get that information. It includes apis, servers, routes, and automation.", LessonSolution="image"},
                new Lesson{LessonId=2, LessonNumber=3, LessonTitle="The Finish", LessonMain="The next pattern that deals with position is the ending. RegEx can find a pattern at the end of a text block. It doesn't matter what is at the end of a text block. It could be letters, words, numbers, or other characters. Punctuation is always good to consider when searching strings. This is important for the beginning, middle, or end of a text block. Using a literal pattern, find the last word in the following paragraph, including punctuation.", LessonChallenge="While all websites will ultimately be using HTML, CSS, and JavaScript, this does not mean developers have not implemented technologies, called frameworks, to help them build websites. Frameworks can be used to build the Front End. Every framework has foundational code it implements under the hood. The three most popular frameworks for the Front End are React, Angular, and Vue. All three of these frameworks are based in the JavaScript programming language!", LessonSolution="language!"},
                new Lesson{LessonId=3, LessonNumber=4, LessonTitle="Global Flag", LessonMain="Flags are characters you add at the end of a RegEx expression that provide extra functionality. The first flag we will discuss is the global ('g') flag. A proper RegEx expression looks like this. Example 1: /website/. This example will only find the first item that matches the exact pattern. In this case, the first time the word 'website' is found in the text block. To find all items that match a given RegEx pattern, you must add the global flag at the end. Example 2: /website/g. This example will find all the items that match 'website' in the text block. In the following paragraph, find all the words that match 'framework'.", LessonChallenge="Frameworks can also be used for the Back End. A popular Back End framework is Node.js. It implements JavaScript behind the scenes. A framework that uses Python as its base computer language is Django. This framework includes a lot of out-of-th-box functionality. It even has a user-interface for admins dealing with server data. Other frameworks developers use include Laravel (PHP framework), Spring Boot (Java framework), and .NET (C# framework).", LessonSolution="Websites"}
            };

            Lesson lesson = new Lesson{LessonId=0, LessonNumber=1, LessonTitle="Beginnings", LessonMain="Welcome to the RegEx Rex course. RegEx is a way to search for patterns in text. You can search for letters, words, and digits. You can search for a certain length of words and a lot of other patterns. In normal searches, what is being used are literal characters. Searching for 'code' is searching for the exact pattern of letters that spell out the word. In the first couple of lessons, we will be focusing on literal characters to explore different patterns that RegEx can be used for. The first pattern we will discuss is the beginning. RegEx can be used to search for a pattern at the very start of a text block. Use the search bar above to solve the lesson's challenge. Ignore the second text box for now. Using literal characters, search for the first word in the following paragraph.", LessonChallenge="Websites are built using three main languages: HTML, CSS, and JavaScript. These three languages are usually explained by comparing them to a house. HTML is the physical brick of the house. It is the physical content which makes up the website. CSS is the paint you apply to the brick or door. It makes the content on the webpage look better. JavaScript is the doorbell of the house. Its responsibility is to produce some kind of functionality to the house. JavaScript does the same with the website.", LessonSolution="Websites"};

            for (int i = 0; i < lessons.Count; i++) {
                if (lessons[i].LessonNumber == id) {
                    lesson = lessons[i];
                }
            }
            // Lesson lesson = lessons.Where( x => x > 7).ToList();

            return lesson;

        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreateLesson(Lesson less)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLesson(Lesson less)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLesson(Lesson less)
        {
            throw new System.NotImplementedException();
        }
    }
}

            // foreach (var lessonItem in lessons) {
            //     if (lessonItem.LessonNumber == id) {
            //         lesson = lessonItem;
            //     }
            // }