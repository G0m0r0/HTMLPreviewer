using System.Threading.Tasks;

namespace HTMLPreviewer.Services
{
    public interface ICheckOriginalService
    {
        Task<bool> CheckOriginalAsync(string html);
    }
}
