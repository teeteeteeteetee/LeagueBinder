using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

/// <summary>
///  3rd party libraries
/// </summary>
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LeagueBinder
{
    public class DDragon
    {
        HttpClient Client = new HttpClient();

        private string Parse(string URL)
        {
            Task<string> task = Task.Run(async () => await Client.GetStringAsync(URL));
            task.Wait();
            return task.Result;
        }

        public string GetVersion()
        {
            List<string> VERSIONS = JsonConvert.DeserializeObject<List<string>>(Parse($"https://ddragon.leagueoflegends.com/api/versions.json"));
            return VERSIONS[0];
        }

        public string GetChampions()
        {
            return Parse($"https://ddragon.leagueoflegends.com/cdn/{GetVersion()}/data/en_US/champion.json");
        }
    }
}
