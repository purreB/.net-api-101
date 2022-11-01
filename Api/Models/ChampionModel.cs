namespace Api.Models
{
	public class ChampionModel
	{
		public string? Name { get; }
		public string? Title { get; }
		public string? Blurb { get; }
		public ChampionInfoModel? ChampionInfo;
	}
}
