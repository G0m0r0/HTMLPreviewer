namespace HTMLPreviewer.Controllers
{
    using HTMLPreviewer.Data.Models;
    using HTMLPreviewer.Models;
    using HTMLPreviewer.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public async Task<IActionResult> Index(int id)
        {
            if (id == 0)
            {
                return View(new InputViewModel {Id=0,HTML=string.Empty });
            }

            var model = await this.homeService.GetByIdAsyn(id);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(InputViewModel model)
        {
            //.this request response header body redirect dbcontext
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var id = await this.homeService.CreateAsync(model);

            return Redirect($"/Home?id={id}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
