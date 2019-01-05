using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookService.WebAPI.Models
{
    public class Rating : EntityBase
    {
        [Range (1,5, ErrorMessage ="rate between 1 and 5")]
        public int RatingScore { get; set; }
    }
}
