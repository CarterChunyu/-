using Microsoft.AspNetCore.Mvc;

namespace DocumentsWeb.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
