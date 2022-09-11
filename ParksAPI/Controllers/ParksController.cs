using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI.Models;

namespace ParksAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksAPIContext _db;

    public ParksController(ParksAPIContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Query a specific api endpoint, park type, city or state where park is located, and a park feature.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string type, string city, string state, string feature)
    {
      var query = _db.Parks.AsQueryable();

      if(type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if(city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if(state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      if(feature != null)
      {
        query = query.Where(entry => entry.Feature == feature);
      }


      return await query.ToListAsync();
      
    }

/// <summary>
/// Creates a new Park in the database/api.
/// </summary>
/// <remarks>
/// Sample request:
///
///     POST /Park
///     {
///        "Parkid": 5,
///        "ParkName": "Badlands",
///        "Type": "National",
///        "City": "Interior",
///        "State": "South Dakota",
///        "Feature": "hiking"
///     }
///
/// </remarks>
/// <response code="201">Returns the newly created park</response>
/// <response code="400">If the item is null</response>  
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = park.ParkId }, park);
    }

    /// <summary>
    /// Query a specific park based on it's id
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    /// <summary>
    /// Edit a specific park's information based on it's id
    /// </summary>
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
        catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    /// <summary>
    /// Delete a specific park based on it's id
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

  }
}