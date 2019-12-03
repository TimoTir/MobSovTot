using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MobSovAlytalo.Models;

namespace MobSovAlytalo.Controllers
{
    public class TaloController : Controller
    {
        private MobSovAlytaloEntities db = new MobSovAlytaloEntities();

        // GET: Talo
        public ActionResult Index()
        {
            return View(db.Talo.ToList());
        }

        // GET: Talo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Talo talo = db.Talo.Find(id);
            if (talo == null)
            {
                return HttpNotFound();
            }
            return View(talo);
        }

        // GET: Talo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HuoneID,Huone")] Talo talo)
        {
            if (ModelState.IsValid)
            {
                db.Talo.Add(talo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(talo);
        }

        // GET: Talo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Talo talo = db.Talo.Find(id);
            if (talo == null)
            {
                return HttpNotFound();
            }
            return View(talo);
        }

        // POST: Talo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HuoneID,Huone")] Talo talo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(talo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(talo);
        }

        // GET: Talo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Talo talo = db.Talo.Find(id);
            if (talo == null)
            {
                return HttpNotFound();
            }
            return View(talo);
        }

        // POST: Talo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Talo talo = db.Talo.Find(id);
            db.Talo.Remove(talo);
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
