using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Items.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(nameof(Create));
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var item = _context.Items.Find(Id);

            _context.Items.Remove(item);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
