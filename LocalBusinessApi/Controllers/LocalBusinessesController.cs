using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using LocalBusinessApi.Models;
using System.Linq;
namespace LocalBusinessApi.Controllers
{
  
  
  [Route("api/[controller]")]
  [ApiController]
  public class LocalBusinessesController :ControllerBase
  {
    private readonly LocalBusinessContext _db;
    public LocalBusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LocalBusiness>>> Get()
    {
      var list = await _db.LocalBusinesses.ToListAsync();
      return list;
    }
      [HttpPost]
    public async Task<ActionResult<LocalBusiness>> Post(LocalBusiness localbusiness)
    {
      _db.LocalBusinesses.Add(localbusiness);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post",new{id= localbusiness.LocalBusinessId},localbusiness);
    }



  }
}

