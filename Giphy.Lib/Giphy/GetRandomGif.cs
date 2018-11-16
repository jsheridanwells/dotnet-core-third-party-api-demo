using System;
using System.Net.Http;
using System.Threading.Tasks;
using Giphy.Lib.Models;
using Newtonsoft.Json;

namespace Giphy.Lib.Giphy
{
    public class GetRandomGif : IGetRandomGif
    {
        public async Task<GiphyModel> ReturnRandomGif(string searchQuery)
        {
            const string giphyKey = "";

            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchQuery}&limit=1/");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}