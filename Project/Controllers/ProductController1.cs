using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Models;

namespace Project.Controllers
{
    public class ProductController1 : Controller
    {
        private readonly AppDbContext  _context;

        public ProductController1(AppDbContext context)
        {
            _context = context;
        }
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }
        //}

        public IActionResult Detail(int id)
        {
            if (id <= 0) return   BadRequest();
                     
            Product product =_context.products.FirstOrDefault(product => product.Id == id);

            if (product == null)  return NotFound();
            
            return View(product);
        }
    }
}
