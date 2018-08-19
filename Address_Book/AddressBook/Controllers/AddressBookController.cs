using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class AddressBookController : Controller
    { 

        //Database connection
        mydatabaseEntities db = new mydatabaseEntities();

        
        // GET: AddressBook
        public ActionResult Index()
        {
            return View();
        }
        //Get all users
        public JsonResult GetAll()
        {
            List<User> alluser = new List<User>();
            
            alluser = db.Users.OrderBy(u => u.FirstName).ToList();
            

            return new JsonResult { Data = alluser, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        //Create user
        [HttpGet]
        public ActionResult Save()
        {
           
                return View(new User());
           
        }
        //Save user into the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(User user)
        {
            //Check if model state is valid
            if (ModelState.IsValid)
            {
               
                    db.Users.Add(user);
                    db.SaveChanges();

                
                return RedirectToAction("Index");
            }
            return View(user);
        }
            
    }
}