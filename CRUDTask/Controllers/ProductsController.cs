using Microsoft.AspNetCore.Mvc;

namespace CRUDTask.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
