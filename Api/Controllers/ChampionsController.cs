using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Newtonsoft.Json;
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
			var champion = new ChampionModel("Aatrox", "the Darkin Blade", "Once honored defenders of Shurima against the Void, Aatrox and his brethren would eventually become an even greater threat to Runeterra, and were defeated only by cunning mortal sorcery. But after centuries of imprisonment, Aatrox was the first to find...", new ChampionInfoModel(8, 4, 3, 4));

			var serializedChampionInfo = JsonConvert.SerializeObject(champion);
			return serializedChampionInfo;
		}
	}
}