namespace HTMLPreviewer.Services
{
    using HTMLPreviewer.Data.Models;
    using System.Threading.Tasks;

    public interface IHomeService
    {
        Task<int> CreateAsync(InputViewModel model);

        Task<InputViewModel> GetByIdAsyn(int id);
    }
}
