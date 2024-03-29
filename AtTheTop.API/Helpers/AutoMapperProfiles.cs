using System.Linq;
using AutoMapper;
using AtTheTop.API.Dtos;
using AtTheTop.API.Models;

namespace AtTheTop.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // CreateMap<User, UserForListDto>()
            //     .ForMember(dest => dest.PhotoUrl, opt => {
            //         opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            //     })
            //     .ForMember(dest => dest.Age, opt => {
            //         opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            //     });
            CreateMap<User, UserForDetailedDto>()
                // .ForMember(dest => dest.PhotoUrl, opt => {
                //     opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                // })
                .ForMember(dest => dest.Age, opt => {
                    opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<Summit, SummitsForUserDto>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}