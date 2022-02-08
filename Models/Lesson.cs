using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Rex.Models
{
    public record Lesson
    {
        // [Key]
        public int LessonId { get; init; }

        [Required]
        public int LessonNumber {get; init;}

        [Required]
        [MaxLength(100)]
        public string LessonTitle {get; init;}

        [Required]
        [MaxLength(1000)]
        public string LessonMain {get; init;}

        [Required]
        [MaxLength(1000)]
        public string LessonChallenge {get; init;}

        [Required]
        [MaxLength(100)]
        public string LessonSolution {get; init;}

        [Required]
        public DateTime LessonCreation {get; init;}

        public DateTime LessonUpdate {get; init;}

    }
}