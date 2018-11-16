using System.Threading.Tasks;
using Giphy.Lib.Giphy;
using Giphy.Lib.Models;

namespace Giphy.Lib.Services
{
    public class GiphyService : IGiphyService
    {
        private readonly IGetRandomGif _getRandomGif;
        public GiphyService(IGetRandomGif getRandomGif)
        {
            _getRandomGif = getRandomGif;
        }
        public async Task<GiphyModel> GetRandomGif(string searchQuery)
        {
            return await _getRandomGif.ReturnRandomGif(searchQuery);
        }
    }
}