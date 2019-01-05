using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace BookService.WebAPI.Repositories
{
    public class RatingRepository : Repository<Rating>
    {
        public RatingRepository( BookServiceContext context) : base(context)
        {

        }

        public override IQueryable<Rating> GetAll()
        {
            return db.Ratings.Include(r => r.Reader).Include(r => r.Book).AsNoTracking();
        }
    }
}
