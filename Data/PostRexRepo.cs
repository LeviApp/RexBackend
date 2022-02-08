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
        public Lesson GetIndividualLesson(int id)
        {
            return _context.Lessons.FirstOrDefault(l => l.LessonNumber == id);
        }

        public IEnumerable<Lesson> GetLessons()
        {
            return _context.Lessons.ToList();
        }
    }
}