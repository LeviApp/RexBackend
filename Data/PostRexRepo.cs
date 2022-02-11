using System;
using System.Collections.Generic;
using System.Linq;
using Rex.Models;

namespace Rex.Data
{
    public class PostRexRepo : IRexRepo
    {
        private readonly RexContext _context;

        public PostRexRepo(RexContext context)
        {
            _context = context;
        }

        public void CreateLesson(Lesson less)
        {
            if (less == null) 
            {
                throw new ArgumentNullException(nameof(less));
            }
            
            _context.Lessons.Add(less);
        }

        public Lesson GetIndividualLesson(int id)
        {
            return _context.Lessons.FirstOrDefault(l => l.LessonNumber == id);
        }

        public IEnumerable<Lesson> GetLessons()
        {
            return _context.Lessons.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}