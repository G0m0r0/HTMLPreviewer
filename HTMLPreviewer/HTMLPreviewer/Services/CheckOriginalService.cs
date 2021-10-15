namespace HTMLPreviewer.Services
{
    using HTMLPreviewer.Data;
    using HTMLPreviewer.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class CheckOriginalService : ICheckOriginalService
    {
        private readonly HTMLPreviewerDbContext db;
        public CheckOriginalService(HTMLPreviewerDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> CheckOriginalAsync(string html)
        {
            HTMLBox element =await db.HTMLBoxes.FirstOrDefaultAsync(x => x.HTML.Equals(html));

            return element != null;
        }
    }
}
