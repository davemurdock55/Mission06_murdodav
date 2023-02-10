using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_murdodav.Models
{
    public class Movie
    {
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public byte Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Sorry, notes may only be 25 characters long")]
        public string Notes { get; set; }

    }
}
