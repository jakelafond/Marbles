using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Marbles.Models;
using Marbles;


namespace Marbles.Controllers
{
    [Route("api/[controller]")]
    public class MarblesController : Controller
    {
        //marble bag
        List<MarbleModel> marbleBag = new List<MarbleModel>();
        MarbleModel myMarble = new MarbleModel();
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(marbleBag);
        }

        // GET api/Marbles
        [HttpGet]
        public MarbleModel CreateMarble()
        {
            MarbleModel newMarble = new MarbleModel();
            return newMarble;
        }

        // GET api/Marbles/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Marbles
        [HttpPost]
        public IActionResult Add([FromForm]string color)
        {
            var newMarble = new MarbleModel{
                Color = color
            };
            marbleBag.Add(newMarble);
            foreach (var item in marbleBag)
            {
                Console.WriteLine(item);
                
            }
            return RedirectToAction("Index");
        }

        // PUT api/Marbles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Marbles/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
