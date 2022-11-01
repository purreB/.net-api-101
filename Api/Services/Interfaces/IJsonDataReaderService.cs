using System.Collections.Generic;

namespace Api.Services
{
  public interface IJsonDataReaderService
  {
    public Task<IEnumerable<ChampionModel>> ExtractChampionsFromJsonData();
  }

}