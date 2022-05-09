using ContosoRecipies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoRecipies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipies([FromQuery] int count)
        {
            //below is a really basic API request, it's a string array of recipies that is returned if any are found (and returns the count)
            /*            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings" };

                        if (!recipes.Any())
                            return NotFound();       
                        return Ok(recipes.Take(count));*/

            Recipie[] recipies =
            {
                new() {Title = "Oxtail"},
                new() {Title = "Curry Chicken"},
                new() {Title = "Dumplings"},
            };

            return Ok(recipies.Take(count));
        }

        [HttpPost]
        public ActionResult CreateNewRecipie([FromBody] Recipie newRecipie)
        {
            //validate and save to the database
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();

            return Created("", newRecipie);
        }



        [HttpDelete("id")] // /api/recipes/all | "{id}" can be used as a parameter then add string/guid ID in to DeleteRecipes(string id) for example | "all" can be used to delete everything
        public ActionResult DeleteRecipies()
        {
            bool badThingsHappened = false;

            if (badThingsHappened) 
                return BadRequest();

            return NoContent();
        }
    }
}
