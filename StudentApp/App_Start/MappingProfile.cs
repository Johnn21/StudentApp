using AutoMapper;
using StudentApp.Dtos;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Student, StudentDto>();
            Mapper.CreateMap<StudentDto, Student>();

            Mapper.CreateMap<Contest, ContestDto>();
            Mapper.CreateMap<ContestDto, Contest>();

            Mapper.CreateMap<Discipline, DisciplineDto>();
            Mapper.CreateMap<DisciplineDto, Discipline>();

            Mapper.CreateMap<Grade, GradeDto>();
            //Mapper.CreateMap<GradeDto, Grade>();

            Mapper.CreateMap<GradeDto, Grade>()
                .ForMember(g => g.Id, opt => opt.Ignore());


            Mapper.CreateMap<Teacher, TeacherDto>();
            Mapper.CreateMap<TeacherDto, Teacher>();

            Mapper.CreateMap<ContestResponse, ContestResponseDto>();
            Mapper.CreateMap<ContestResponseDto, ContestResponse>();

        }
    }
}