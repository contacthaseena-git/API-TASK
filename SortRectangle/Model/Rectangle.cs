using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SortRectangles.Model
{
    public class Rectangle
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]

        public int length { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]

        public int width { get; set; }
    }
}
