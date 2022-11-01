namespace Api.Models
{
	public class ChampionInfoModel
	{
		private int _attack;
		private int _magic;
		private int _defense;
		private int _difficulty;

		public ChampionInfoModel(int attack, int magic, int defense, int difficulty)
		{
			_attack = attack;
			_magic = magic;
			_defense = defense;
			_difficulty = difficulty;
		}

		public int Attack { get => _attack; set => _attack = value; }
		public int Magic { get => _magic; set => _magic = value; }
		public int Defense { get => _defense; set => _defense = value; }
		public int Difficulty { get => _difficulty; set => _difficulty = value; }
	}
}