using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookService.WebAPI.Models;
using AutoMapper;

namespace BookService.WebAPI.Repositories.Base
{
    public class MappingRepository<T> : Repository<T> where T:EntityBase
    {
        protected readonly IMapper mapper;

        public MappingRepository( BookServiceContext context, IMapper mapper ) : base(context)
        {
            this.mapper = mapper;
        }
    }
}
