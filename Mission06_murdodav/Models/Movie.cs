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
        
        [Required(ErrorMessage = "The Category field is required")]
        public int CategoryID { get; set; } // Getting the categoryID
        public Category Category { get; set; } // Getting a Category object (the two lines above and below create the FK relationship with the Category table)

        [Required(ErrorMessage = "The Title field is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Year field is required")]
        [Range(0, 2023, ErrorMessage = "The Year field must be a number from 0 to 2023")]
        public int ?Year { get; set; }

        [Required(ErrorMessage = "The Director field is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "The Rating field is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Sorry, notes may only be 25 characters long :(")]
        public string Notes { get; set; }

    }
}
