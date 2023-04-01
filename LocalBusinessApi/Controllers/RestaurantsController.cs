using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;

namespace LocalBusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
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
  }
}
