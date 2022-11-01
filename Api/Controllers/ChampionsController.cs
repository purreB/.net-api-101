using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
  [ApiController]
  [Route("leauge-api/v1/[controller]/")]
  public class ChampionsController : Controller
  {
    [HttpGet] // leauge-api/v1/champions/
    public String GetAll()
    {
      //* Read data from json
      //* Format data as list of object, each object is one champion
      //* Send back data
      Console.WriteLine("Gottem");
      return "Hej";
    }
  }
}