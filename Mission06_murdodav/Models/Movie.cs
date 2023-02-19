using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_murdodav.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        // Setting up the foreign key relationship to the Category model/table
        
        [Required]
        public int CategoryID { get; set; } // Getting the categoryID
        public Category Category { get; set; } // Getting a Category object (the two lines above and below create the FK relationship with the Category table)

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

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
