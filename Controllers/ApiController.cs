using _13118EgzaminPraktyczny.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace _13118EgzaminPraktyczny.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private List<Class> NazwaListy;

        public ApiController()
        {
            NazwaListy = new List<Class>()
            {
                new Class() {Id = 1, title = "AAAA", author = "BBBB", price = "100"},
                new Class() {Id = 2, title = "CCCC", author = "DDDD", price = "50"},
                new Class() {Id = 3, title = "EEEE", author = "FFFF", price = "10"}
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Class>> GetCard()
        {
            return NazwaListy.ToList();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = NazwaListy.Find(id);
            return NoContent();
        }

    }
}
