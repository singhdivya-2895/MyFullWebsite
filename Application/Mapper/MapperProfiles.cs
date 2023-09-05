﻿using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class MapperProfiles: Profile
    {
        public MapperProfiles()
        {
            CreateMap<Activity, Activity>();  
        }
    }
}
