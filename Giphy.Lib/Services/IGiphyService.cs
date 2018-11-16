using System.Threading.Tasks;
using Giphy.Lib.Models;

namespace Giphy.Lib.Services
{
    public interface IGiphyService
    {
        Task<GiphyModel> GetRandomGif(string searchQuery);
    }
}