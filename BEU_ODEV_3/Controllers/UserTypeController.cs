using BEU_ODEV_3.Data;
using BEU_ODEV_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_ODEV_3.Controllers
{
    public class UserTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
           
            IList<UserType> ogrenciListesi = _db.UserType.ToList();
            return View(ogrenciListesi);
        }
        
        public IActionResult Create()
        {

            return View();
        }

        
        [HttpPost]
        public IActionResult Create(UserType o)
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
