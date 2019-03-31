using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Services.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration(): this("MyProfile")
        {
        }

        protected AutoMapperProfileConfiguration(string profileName):
            base(profileName)
        {
            //CreateMap<>();
        }
    }
}
