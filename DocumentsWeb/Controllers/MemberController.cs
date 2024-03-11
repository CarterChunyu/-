using Microsoft.AspNetCore.Mvc;

namespace DocumentsWeb.Controllers
{
    public class MemberController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }


    }
}
