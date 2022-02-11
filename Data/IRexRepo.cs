using System.Collections.Generic;
using Rex.Models;
namespace Rex.Data
{
    public interface IRexRepo
    {
        bool SaveChanges();
        IEnumerable<Lesson> GetLessons();
        Lesson GetIndividualLesson(int id);
        void CreateLesson(Lesson less);
        void UpdateLesson(Lesson less);


    }
}