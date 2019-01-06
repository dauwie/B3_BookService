﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookService.WebAPI.Repositories;
using BookService.WebAPI.Models;
using Newtonsoft.Json;

namespace BookService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerCrudBase<Rating,RatingRepository>
    {
        public RatingsController(RatingRepository ratingRepository) : base(ratingRepository)
        {

        }

        //[HttpGet]
        //public override async Task<IActionResult> Get()
        //{
        //    return Ok(await repository.GetAllInclusive());
        //}

        /*Om een selfreferencing loop te vermijden OPTIE 1 */
       // GET: api/Ratings
       [HttpGet]
       public override async Task<IActionResult> Get()
       {

           var settings = new JsonSerializerSettings
           {
               ReferenceLoopHandling = ReferenceLoopHandling.Ignore
           };
           return Ok(JsonConvert.SerializeObject(await repository.GetAllInclusive(),settings));
       }
       


    }
}