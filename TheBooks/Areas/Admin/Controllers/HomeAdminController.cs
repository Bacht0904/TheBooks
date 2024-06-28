using Microsoft.AspNetCore.Mvc;

namespace TheBooks.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
