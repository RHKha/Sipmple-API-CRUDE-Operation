using Akij_Food.AkijFoodData;
using Akij_Food.Models;
using Microsoft.AspNetCore.Mvc;


namespace Akij_Food.Controllers
{
    [ApiController]
    public class ColdDrinksController : ControllerBase
    {
        private IColdDrinkData _coldDrinkData;

        public ColdDrinksController(IColdDrinkData coldDrinkData)
        {
            _coldDrinkData = coldDrinkData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetColdDrinks()
        {
            return Ok(_coldDrinkData.GetColdDrinks());
        }

        [HttpGet]
        [Route("api/[controller]/{name}")]
        public IActionResult GetColdDrinks(string name)
        {
            var coldDrink = _coldDrinkData.GetColdDrink(name);

            if(coldDrink != null)
            {
                return Ok(coldDrink);
            }

            return NotFound($"The drinks name is: {name} NotFound");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddColdDrink(ColdDrink coldDrink)
        {
            _coldDrinkData.AddColdDrink(coldDrink);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + coldDrink.intColdDrinksId, coldDrink);
        }

        [HttpDelete]
        [Route("api/[controller]/{name}")]
        public IActionResult DeletColdDrink(string name)
        {
            var coldDrink = _coldDrinkData.GetColdDrink(name);
            if(coldDrink != null)
            {
                _coldDrinkData.DelelteColdDrinkItem(coldDrink);
                return Ok();
            }
            return NotFound($"Drink name: {name} is not found") ;
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult EditColdDrink(int id, ColdDrink coldDrink)
        {
            var existingColdDrink = _coldDrinkData.GetColdDrink(id);
            if (existingColdDrink != null)
            {
                coldDrink.intColdDrinksId = existingColdDrink.intColdDrinksId;
                _coldDrinkData.EditColdDrink(coldDrink);
            }
            return Ok(coldDrink);
        }
    }
}
