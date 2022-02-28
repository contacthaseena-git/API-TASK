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
        public int length { get; set; }
        [Required]
        public int width { get; set; }
    }
}
