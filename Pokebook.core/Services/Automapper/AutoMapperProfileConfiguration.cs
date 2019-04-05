using AutoMapper;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Services.Automapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {
        }

        protected AutoMapperProfileConfiguration(string profileName) :
            base(profileName)
        {
            CreateMap<Chat, ChatSimpleDTO>()
                .ForMember(
                dest => dest.MessageCount,
                opts => opts.MapFrom(
                    src => src.Messages.Count));
        }
    }
}
