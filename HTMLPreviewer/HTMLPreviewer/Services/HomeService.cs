namespace HTMLPreviewer.Services
{
    using HTMLPreviewer.Data;
    using HTMLPreviewer.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Text;
    using System.Threading.Tasks;
    public class HomeService: IHomeService
    {
        private readonly HTMLPreviewerDbContext db;
        public HomeService(HTMLPreviewerDbContext db)
        {
            this.db = db;
        }

        public async Task<int> CreateAsync(InputViewModel model)
        {
            decimal megabyteSize = ((decimal)Encoding.Unicode.GetByteCount(model.HTML) / (1024 * 1024));
            if (megabyteSize > GlobalConstants.allowedSizeForHTMLFile)
            {
                throw new Exception(GlobalConstants.errorMessageIfAllowedSizeIsExceed);
            }

            var HTMLBox = new HTMLBox
            {
                HTML = model.HTML,
                CreatedOn = DateTime.UtcNow,
                LastEdit = DateTime.UtcNow,
            };

            await this.db.HTMLBoxes.AddAsync(HTMLBox);
            await this.db.SaveChangesAsync();

            return HTMLBox.Id;
        }

        public async Task<InputViewModel> GetByIdAsyn(int id)
        {
           var element= await this.db.HTMLBoxes.FirstOrDefaultAsync(x => x.Id == id);

            if(element==null)
            {
                throw new NotImplementedException(GlobalConstants.errorMessageDataWithSuchId);
            }

            var viewElement = new InputViewModel
            {
                Id = element.Id,
                HTML = element.HTML,
            };

            return viewElement;
        }
    }
}
