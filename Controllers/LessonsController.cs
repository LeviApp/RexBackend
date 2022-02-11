using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Rex.Models;
using Rex.Data;
using AutoMapper;
using Rex.Dtos;

namespace Rex.Controllers
{
    [Route("api/lessons")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly IRexRepo _repo;
        private readonly IMapper _mapper;

        public LessonsController(IRexRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // private readonly MockRexRepo _repo = new MockRexRepo();
        [HttpGet]
        public ActionResult <IEnumerable<LessonReadDto>> GetAllLessons()
        {
            var lessonItems = _repo.GetLessons();

            return Ok(_mapper.Map<IEnumerable<LessonReadDto>>(lessonItems));
        }

        [HttpGet("{id}", Name="GetIndividualLesson")]
        public ActionResult <LessonReadDto> GetIndividualLesson(int id)
        {
            var lessonItem = _repo.GetIndividualLesson(id);

            if (lessonItem != null)
            {
                return Ok(_mapper.Map<LessonReadDto>(lessonItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult <LessonReadDto> CreateIndividualLesson(LessonCreateDto lessonCreateDto)
        {
            var lessonModel = _mapper.Map<Lesson>(lessonCreateDto);
            _repo.CreateLesson(lessonModel);
            _repo.SaveChanges();

            var lessonReadDto = _mapper.Map<LessonReadDto>(lessonModel);

            return CreatedAtRoute(nameof(GetIndividualLesson), new {Id = lessonReadDto.LessonNumber}, lessonCreateDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateLesson(int id, LessonUpdateDto lessonUpdateDto)
        {
            var repoLesson = _repo.GetIndividualLesson(id);

            if (repoLesson == null) {
                return NotFound();
            }

            _mapper.Map(lessonUpdateDto, repoLesson);

            _repo.UpdateLesson(repoLesson);

            _repo.SaveChanges();

            return NoContent();
        }
    }
}