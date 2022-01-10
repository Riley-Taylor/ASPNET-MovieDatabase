using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class MovieListModel
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public int MovieReview { get; set; }
    }
}
