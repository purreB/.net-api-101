namespace Api.Models
{
	public class ChampionInfoModel
	{

		public ChampionInfoModel(int _attack, int _defense, int _magic, int _difficulty)
		{
			attack = _attack;
			magic = _magic;
			defense = _defense;
			difficulty = _difficulty;
		}

		public int attack { get; set; }
		public int defense { get; set; }
		public int magic { get; set; }
		public int difficulty { get; set; }
	}
}