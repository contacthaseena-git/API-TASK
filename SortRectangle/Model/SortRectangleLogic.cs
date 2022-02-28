using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortRectangles.Model
{
    public class SortRectangleLogic:IRectangle
    {

    

        public List<Rectangle> GetSortedRectngles(List<Rectangle> Rectangle)
        {
         List<Rectangle> SortedRectangles = Rectangle.OrderByDescending(x => x.length * x.width).ToList();
            return SortedRectangles;
        }
    }
}
