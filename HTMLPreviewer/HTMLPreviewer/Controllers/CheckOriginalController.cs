namespace HTMLPreviewer.Controllers
{
    using HTMLPreviewer.Data.Models;
    using HTMLPreviewer.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/[Controller]")]
    public class CheckOriginalController : Controller
    {
        private readonly ICheckOriginalService checkOriginalService;
        public CheckOriginalController(ICheckOriginalService checkOriginalService)
        {
            this.checkOriginalService = checkOriginalService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post(CheckOriginalViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return await this.checkOriginalService.CheckOriginalAsync(model.HTMLText);
        }
    }
}
