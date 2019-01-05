using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Models
{
    public class Reader : EntityBase
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public ICollection<Rating> Ratings { get; set; }

    }
}
