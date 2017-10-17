using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleIOT.Models;

namespace SimpleIOT.Controllers
{
    public class CellController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cell
        public ActionResult Index()
        {
            return View(db.Cells.ToList());
        }

        // GET: Cell/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cell cell = db.Cells.Find(id);
            if (cell == null)
            {
                return HttpNotFound();
            }
            return View(cell);
        }

        // GET: Cell/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cell/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] Cell cell)
        {
            if (ModelState.IsValid)
            {
                db.Cells.Add(cell);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cell);
        }

        // GET: Cell/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cell cell = db.Cells.Find(id);
            if (cell == null)
            {
                return HttpNotFound();
            }
            return View(cell);
        }

        // POST: Cell/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] Cell cell)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cell).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cell);
        }

        // GET: Cell/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cell cell = db.Cells.Find(id);
            if (cell == null)
            {
                return HttpNotFound();
            }
            return View(cell);
        }

        // POST: Cell/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cell cell = db.Cells.Find(id);
            db.Cells.Remove(cell);
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
