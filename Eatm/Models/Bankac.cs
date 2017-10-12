using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eatm.Models
{
    public class Bankac
    {
        public int Id { get; set; }
        [Required]
        public int CardNo { get; set; }
        [Required]
        public int PIN { get; set; }
        [Required]
        public double Balance { get; set; }
    }
}