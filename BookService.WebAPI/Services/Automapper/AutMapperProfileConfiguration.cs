using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookService.WebAPI.Models;
using BookService.WebAPI.DTO;

namespace BookService.WebAPI.Services.Automapper
{
    public class AutMapperProfileConfiguration : Profile
    {
        public AutMapperProfileConfiguration() : this("MyProfile")
        {

        }
        public AutMapperProfileConfiguration( string profileName) : base (profileName)
        {
            CreateMap<BookBasic, Book>();

        }
    }
}
