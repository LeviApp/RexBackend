using System.Collections.Generic;
using Rex.Models;
namespace Rex.Data
{
    public interface IRexRepo
    {
        IEnumerable<Lesson> GetLessons();

        Lesson GetIndividualLesson(int id);

    }
}