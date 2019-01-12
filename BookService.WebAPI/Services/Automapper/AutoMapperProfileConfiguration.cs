using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookService.WebAPI.DTO;
using BookService.WebAPI.Models;

namespace BookService.WebAPI.Services.Automapper
{
    public class AutoMapperProfileConfiguration : AutoMapper.Profile
    {
        public AutoMapperProfileConfiguration(): this ("MyProfile")
        {

        }
        public AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<BookDetail, Book>();
        }
    }
}
