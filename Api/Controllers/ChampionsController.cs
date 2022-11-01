using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("leauge-api/v1/[controller]/")]
	public class ChampionsController : Controller
	{
		[HttpGet] // leauge-api/v1/champions/
		[Route("hello")]
		public String GetAll()
		{
			Console.WriteLine("Gottem");
			return "Hej";
		}
	}
}