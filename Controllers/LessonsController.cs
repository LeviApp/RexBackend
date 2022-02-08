using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Rex.Models;
using Rex.Data;

namespace Rex.Controllers
{
    [Route("api/lessons")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly IRexRepo _repo;

        public LessonsController(IRexRepo repo)
        {
            _repo = repo;
        }
        // private readonly MockRexRepo _repo = new MockRexRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Lesson>> GetAllLessons()
        {
            var lessonItems = _repo.GetLessons();

            return Ok(lessonItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Lesson> GetIndividualLesson(int id)
        {
            var lessonItem = _repo.GetIndividualLesson(id);

            return Ok(lessonItem);
        }
    }
}