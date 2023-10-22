using SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SachOnline.Areas.Admin.Controllers
{
    public class ChuDe1Controller : Controller
    {
        // GET: Admin/ChuDe1
        BookOnlineEntities db=new BookOnlineEntities();
        public ActionResult Index()
        {
            var data = db.CHUDEs;
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
           
            return View(); 
        }
        [HttpPost]
        public ActionResult Create(CHUDE model)
        {
            if (ModelState.IsValid)
            {
                db.CHUDEs.Add(model);
                db.SaveChanges(); // Save changes to the database

                return RedirectToAction("Index"); // Redirect to a different action
            }

            return View(model); // Return the view with validation errors
        }

    }
}