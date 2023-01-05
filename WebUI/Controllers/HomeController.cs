using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebUI.ViewModels.Home;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;       
        }
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                SliderText=_context.SliderTexts,
                SliderBackrounds=_context.SliderBackrounds
                
            };
            return View(model);
        }
    }
}
