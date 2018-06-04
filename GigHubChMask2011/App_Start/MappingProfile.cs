using AutoMapper;
using GigHubChMask2011.Core.DTOs;
using GigHubChMask2011.Core.Models;

namespace GigHubChMask2011.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ApplicationUser, UserDto>();
                cfg.CreateMap<Gig, GigDto>();
                cfg.CreateMap<Notification, NotificationDto>();
            });
            IMapper mapper = config.CreateMapper();
        }
    }
}