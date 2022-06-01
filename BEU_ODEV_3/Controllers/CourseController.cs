using BEU_ODEV_3.Data;
using BEU_ODEV_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_ODEV_3.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            IList<Course> ogrenciListesi = _db.Course.ToList();
            return View(ogrenciListesi);
        }
        
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Course o)
        {
            if (ModelState.IsValid)
            {
                _db.Add(o);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }

        }
    }
}
