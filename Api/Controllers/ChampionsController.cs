using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers
{
    [ApiController]
    [Route("leauge-api/v1/[controller]/")]
    public class ChampionsController : Controller
    {
        [HttpGet] // leauge-api/v1/champions/
        public ChampionModel GetAll()
        {
            //* Read data from json
            //* Format data as list of object, each object is one champion
            //* Send back data
            var champion = new ChampionModel("Aatrox", "the Darkin Blade", "Once honored defenders of Shurima against the Void, Aatrox and his brethren would eventually become an even greater threat to Runeterra, and were defeated only by cunning mortal sorcery. But after centuries of imprisonment, Aatrox was the first to find...", new ChampionInfoModel());
            Console.WriteLine("Gottem");
            return champion;
        }
    }
}