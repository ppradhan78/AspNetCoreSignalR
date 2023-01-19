using AspNetCoreSignalR.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR.Controllers
{
    public class ServerController : Controller
    {
        private readonly IHubContext<NotificationHub> _notificationHub;

        public ServerController(IHubContext<NotificationHub> notificationHub)
        {
            _notificationHub = notificationHub;
        }

        [HttpPost]
        public async Task<IActionResult> Index(Notification model)
        {
           await _notificationHub.Clients.All.SendAsync("ReciveMsg", model.Message);
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
