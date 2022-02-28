using NUnit.Framework;
using SortRectangles.Model;
using System.Collections.Generic;

namespace SortLogicTest
{
    public class SortLogicTests
    {


        [Test]
        public void SortDescnding()
        {
            var sorting = new SortRectangleLogic();

            var Rectanglelist = new List<Rectangle>
            {
           new Rectangle(){length=3,width=4},
            new Rectangle(){length=5,width=5},
            new Rectangle(){length=4,width=4}
            };

            List<Rectangle> sortedlist = Rectanglelist.GetSortedRectngles(Rectanglelist);

            Assert.Equals(5, sortedlist[0].length);
        }



        [Test]
        public void NegativeValuesTest()
        {
            var sorting = new SortRectangleLogic();

            var Rectanglelist = new List<Rectangle>
            {
           new Rectangle(){length=3,width=4},
            new Rectangle(){length=5,width=5},
            new Rectangle(){length=4,width=4}
            };

            List<Rectangle> sortedlist = sorting.GetSortedRectngles(Rectanglelist);

            Assert.Warn("Please Enter Valid Length and width");

        }
    }
}