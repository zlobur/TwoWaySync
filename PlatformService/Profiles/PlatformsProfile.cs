using AutoMapper;
using PlatformService.DTO;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
                // source -> Target 
                CreateMap<Platform, PlatformReadDto>();
                CreateMap<PlatformCreateDto, Platform>();
        }   
    }
}