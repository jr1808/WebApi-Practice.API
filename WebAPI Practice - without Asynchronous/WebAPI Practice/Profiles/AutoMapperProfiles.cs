using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practice.DomainModels;
using DataModels = WebAPI_Practice.DataModels;


namespace WebAPI_Practice.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
            .ReverseMap();
            CreateMap<DataModels.Gender, Gender>()
            .ReverseMap();
            CreateMap<DataModels.Address, Address>()
            .ReverseMap();

        }
    }
}
