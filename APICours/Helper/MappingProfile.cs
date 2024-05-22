using AutoMapper;
using APICours.Dtos;
using APICours.Models;
namespace APICours.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<CoursDto, Cours>();
            CreateMap<LeconDto, Lecon>();
        }
    }
}
