namespace Api.Models
{
    public class ChampionInfoModel
    {

        public ChampionInfoModel(ChampionInfoModel info)
        {
            attack = info.attack;
            magic = info.magic;
            defense = info.defense;
            difficulty = info.difficulty;
        }

        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
    }
}