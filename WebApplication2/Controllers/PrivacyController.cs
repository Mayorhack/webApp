using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return File("~/privacy/index.html", "text/html");
        }
    }
}
