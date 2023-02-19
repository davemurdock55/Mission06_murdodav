using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_murdodav.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage ="The Category ID field is required")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="The Category Name field is required")]
        public string CategoryName { get; set; }
    }
}
