using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookService.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookService.WebAPI.Repositories;

namespace BookService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadersController : ControllerCrudBase <Reader,ReaderRepository >
    {
        public ReadersController( ReaderRepository readerRepository) :base(readerRepository)
        {

        }

    }
}