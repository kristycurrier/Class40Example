using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Class40ExampleDotNet.Models
{
    public class DemoInputModel
    {
        [Required]
        [MaxLength(5)]
        [MinLength(0)]
        public string FirstName { get; set; }
        [Required]
        public string Game { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public bool PlaysGame { get; set; }
    }
}