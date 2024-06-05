using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LvhLesson06CF.Models; // Add this to include your models namespace

namespace LvhLesson06CF.Controllers
{
    public class LvhCategoriesController : Controller
    {
        private static LvhBookStore lvhDb = new LvhBookStore();

        public LvhCategoriesController()
        {
        }

        // GET: Lvhcategories
        public ActionResult LvhIndex()
        {
            /*
             * khởi tạo DbContext:
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .NET Framework trên máy
             * và sau đó tạo csdl
             */
            var lvhCategories = lvhDb.LvhCategories.ToList();
            return View(lvhCategories);
        }

        public ActionResult LvhCreate()
        {
            var lvhCategory = new LvhCategory();
            return View(lvhCategory);
        }

        [HttpPost]
        public ActionResult LvhCreate(LvhCategory lvhCategory)
        {
            if (ModelState.IsValid)
            {
                lvhDb.LvhCategories.Add(lvhCategory);
                lvhDb.SaveChanges();
                return RedirectToAction("LvhIndex");
            }
            return View(lvhCategory);
        }
    }
}
