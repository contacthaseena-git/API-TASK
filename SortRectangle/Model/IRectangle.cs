using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortRectangles.Model
{
 public interface IRectangle
    {
        List<Rectangle> GetSortedRectngles(List<Rectangle> Rectangles);
    }
}
