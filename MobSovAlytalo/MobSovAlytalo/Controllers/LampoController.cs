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
    public class LampoController : Controller
    {
        private MobSovAlytaloEntities db = new MobSovAlytaloEntities();

        // GET: Lampo
        public ActionResult Index()
        {
            return View(db.Lampo.ToList());
        }

        // GET: Lampo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lampo lampo = db.Lampo.Find(id);
            if (lampo == null)
            {
                return HttpNotFound();
            }
            return View(lampo);
        }

        // GET: Lampo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lampo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LampoID,TalonTavoiteLampo,TalonNykyLampo")] Lampo lampo)
        {
            if (ModelState.IsValid)
            {
                db.Lampo.Add(lampo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lampo);
        }

        // GET: Lampo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lampo lampo = db.Lampo.Find(id);
            if (lampo == null)
            {
                return HttpNotFound();
            }
            return View(lampo);
        }

        // POST: Lampo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LampoID,TalonTavoiteLampo,TalonNykyLampo")] Lampo lampo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lampo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lampo);
        }

        // GET: Lampo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lampo lampo = db.Lampo.Find(id);
            if (lampo == null)
            {
                return HttpNotFound();
            }
            return View(lampo);
        }

        // POST: Lampo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lampo lampo = db.Lampo.Find(id);
            db.Lampo.Remove(lampo);
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
