using System.Threading.Tasks;
using Giphy.Lib.Models;

namespace Giphy.Lib.Giphy
{
    public interface IGetRandomGif
    {
        Task<GiphyModel> ReturnRandomGif(string searchQuery);
    }
}