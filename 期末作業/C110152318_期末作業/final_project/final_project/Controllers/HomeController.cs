using System.Diagnostics;
using final_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // �n���B�z
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // �n���޿�A�Ҧp�ˬd�b���M�K�X�O�_���T
            if (IsValidLogin(email, password))
            {
                // �n�����\�A���w�V�쭺���λ���O
                return RedirectToAction("Index");
            }
            else
            {
                // �n�����ѡA��^��������ܿ��~
                ViewBag.ErrorMessage = "Invalid login attempt.";
                return View("Index");
            }
        }

        private bool IsValidLogin(string email, string password)
        {
            // �o�̶i��n�������޿�]�Ҧp�P�ƾڮw���^
            return true; // ���]�`�O���\
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
