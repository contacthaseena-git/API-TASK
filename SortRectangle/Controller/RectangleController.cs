using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SortRectangles.Model;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SortRectangles.Controller
{
    public class RectangleController : ControllerBase
    {
        private readonly IRectangle Rect;
        public RectangleController(IRectangle rect)
        {
            this.Rect = rect;
        }
        // GET: /<controller>/
        [HttpGet]
        [Route("")]
        [Route("Rectangle")]
        [AllowAnonymous]
        public IActionResult RectangleSort([FromBody] List<Rectangle> rectangles)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var SortedRectangles = Rect.GetSortedRectngles(rectangles);
                return Ok(SortedRectangles);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
