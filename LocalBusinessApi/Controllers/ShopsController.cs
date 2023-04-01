using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;

namespace LocalBusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private readonly LocalBusinessApiContext _db;

    public ShopsController(LocalBusinessApiContext db)
    {
      _db = db;
    }

    // GET api/Shops
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shop>>> Get()
    {
      return await _db.Shops.ToListAsync();
    }

    // GET: api/Shops/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Shop>> GetShop(int id)
    {
      Shop shop = await _db.Shops.FindAsync(id);

      if (shop == null)
      {
        return NotFound();
      }

      return shop;
    }

    // POST api/Shops
    [HttpPost]
    public async Task<ActionResult<Shop>> Post(Shop shop)
    {
      _db.Shops.Add(shop);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetShop), new { id = shop.ShopId }, shop);
    }
    
    
    
    // PUT: api/Shops/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Shop shop)
    {
      if (id != shop.ShopId)
      {
        return BadRequest();
      }

      _db.Shops.Update(shop);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShopExists(id))
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

    private bool ShopExists(int id)
    {
      return _db.Shops.Any(e => e.ShopId == id);
    }



  }
}
