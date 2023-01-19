using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSignalR.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
