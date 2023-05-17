using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentitySystem.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
