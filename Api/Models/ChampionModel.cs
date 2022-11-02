namespace Api.Models
{
    public class ChampionModel
    {
        public ChampionModel(string _name, string _title, string _blurb, ChampionInfoModel championInfo)
        {
            name = _name;
            title = _title;
            blurb = _blurb;
            championInfo = new ChampionInfoModel(championInfo);
        }
        public string name { get; set; } = null!;
        public string title { get; set; } = null!;
        public string blurb { get; set; } = null!;
        public ChampionInfoModel info = null!;

    }
}
