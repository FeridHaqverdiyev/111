using Microsoft.AspNetCore.Mvc;
using Project.DAL;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers
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
            
            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();
            List<Slide> slides =_context.Slides.OrderBy(s=>s.Order).Take(2).ToList();
            List<Product> products = _context.products.ToList();
            List<Product> LatestProducts=_context.products.OrderByDescending(p => p.Id).Take(8).ToList();
          


            HomeVM home = new HomeVM
            {
                Slides = slides,
                Products = products,
                LatestProducs=LatestProducts,

              
            };

            return View(home);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
