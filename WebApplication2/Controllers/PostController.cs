using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class PostController : Controller
    {
        [HttpGet("post/{pid}")]
        public IActionResult Index(string pid)
        {
            return File($"~/post/[pid]/index.html", "text/html");
        }
    }
}
