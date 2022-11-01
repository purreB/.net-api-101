namespace Api.Models
{
	public class ChampionInfoModel
	{

		public ChampionInfoModel(int attack, int magic, int defense, int difficulty)
		{
			Attack = attack;
			Magic = magic;
			Defense = defense;
			Difficulty = difficulty;
		}

		public int Attack { get => Attack; set => Attack = value; }
		public int Magic { get => Magic; set => Magic = value; }
		public int Defense { get => Defense; set => Defense = value; }
		public int Difficulty { get => Difficulty; set => Difficulty = value; }
	}
}