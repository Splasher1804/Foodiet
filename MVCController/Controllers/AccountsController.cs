using Microsoft.AspNetCore.Mvc;
namespace MVCController.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Verify()
        {
            return View();
        }
    }
}
