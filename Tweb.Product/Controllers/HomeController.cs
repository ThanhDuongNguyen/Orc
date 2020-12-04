using Microsoft.AspNetCore.Mvc;

namespace Tweb.Product.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
