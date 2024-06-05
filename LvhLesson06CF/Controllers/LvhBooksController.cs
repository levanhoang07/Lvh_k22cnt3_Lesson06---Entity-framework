using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using LvhLesson06CF.Models;

namespace LvhLesson06CF.Controllers
{
    public class LvhBooksController : Controller // Changed the class name
    {
        private LvhBookStore db = new LvhBookStore();

        // GET: LvhBooks
        public ActionResult Index()
        {
            return View(db.LvhBooks.ToList()); // Updated to use LvhBooks
        }

        // GET: LvhBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LvhBook lvhBook = db.LvhBooks.Find(id); // Updated to use LvhBooks
            if (lvhBook == null)
            {
                return HttpNotFound();
            }
            return View(lvhBook);
        }

        // GET: LvhBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LvhBooks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Author,ISBN")] LvhBook lvhBook) // Updated to use LvhBook
        {
            if (ModelState.IsValid)
            {
                db.LvhBooks.Add(lvhBook); // Updated to use LvhBooks
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lvhBook);
        }

        // GET: LvhBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LvhBook lvhBook = db.LvhBooks.Find(id); // Updated to use LvhBooks
            if (lvhBook == null)
            {
                return HttpNotFound();
            }
            return View(lvhBook);
        }

        // POST: LvhBooks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Author,ISBN")] LvhBook lvhBook) // Updated to use LvhBook
        {
            if (ModelState.IsValid)
            {
                db.Entry(lvhBook).State = EntityState.Modified; // Updated to use LvhBook
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lvhBook);
        }

        // GET: LvhBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LvhBook lvhBook = db.LvhBooks.Find(id); // Updated to use LvhBooks
            if (lvhBook == null)
            {
                return HttpNotFound();
            }
            return View(lvhBook);
        }

        // POST: LvhBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LvhBook lvhBook = db.LvhBooks.Find(id); // Updated to use LvhBooks
            db.LvhBooks.Remove(lvhBook); // Updated to use LvhBooks
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
