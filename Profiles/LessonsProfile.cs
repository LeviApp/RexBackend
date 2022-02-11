using AutoMapper;
using Rex.Dtos;
using Rex.Models;

namespace Rex.Profiles
{
    public class LessonsProfile : Profile
    {
        public LessonsProfile()
        {
            CreateMap<Lesson, LessonReadDto>();
            CreateMap<LessonCreateDto, Lesson>();
            CreateMap<LessonUpdateDto, Lesson>();
        }
    }
}