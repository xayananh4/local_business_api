using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace LocalBusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class RestaurantsController : ControllerBase
  {
    private readonly LocalBusinessApiContext _db;

    public RestaurantsController(LocalBusinessApiContext db)
    {
      _db = db;
    }

    // GET api/Restaurants
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Restaurant>>> Get()
    {
      return await _db.Restaurants.ToListAsync();
    }

    // GET: api/Restaurants/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
    {
      Restaurant restaurant = await _db.Restaurants.FindAsync(id);

      if (restaurant == null)
      {
        return NotFound();
      }

      return restaurant;
    }

    // POST api/restaurants
    [HttpPost]
    public async Task<ActionResult<Restaurant>> Post(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.RestaurantId }, restaurant);
    }


    // PUT: api/Restaurants/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Restaurant restaurant)
    {
      if (id != restaurant.RestaurantId)
      {
        return BadRequest();
      }

      _db.Restaurants.Update(restaurant);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RestaurantExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool RestaurantExists(int id)
    {
      return _db.Restaurants.Any(e => e.RestaurantId == id);
    }

    // DELETE: api/Restaurants/1
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRestaurant(int id)
    {
      Restaurant restaurant = await _db.Restaurants.FindAsync(id);
      if (restaurant == null)
      {
        return NotFound();
      }

      _db.Restaurants.Remove(restaurant);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
