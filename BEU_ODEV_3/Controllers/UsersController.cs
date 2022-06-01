using BEU_ODEV_3.Data;
using BEU_ODEV_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_ODEV_3.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            IList<Users> UsersList = _db.Users.ToList();
            return View(UsersList);
        }
     
        public IActionResult Create()
        {

            return View();
        }

   
        [HttpPost]
        public IActionResult Create(Users o)
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
