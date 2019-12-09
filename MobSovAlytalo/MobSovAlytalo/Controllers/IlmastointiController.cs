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
    public class IlmastointiController : Controller
    {
        private MobSovAlytaloEntities db = new MobSovAlytaloEntities();

        // GET: Ilmastointi
        public ActionResult Index()
        {
            return View(db.Ilmastointi.ToList());
        }

        // GET: Ilmastointi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilmastointi ilmastointi = db.Ilmastointi.Find(id);
            if (ilmastointi == null)
            {
                return HttpNotFound();
            }
            return View(ilmastointi);
        }

        // GET: Ilmastointi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ilmastointi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IlmastointiId,IlmastoinninTila,TavoiteLampo,HuoneId")] Ilmastointi ilmastointi)
        {
            if (ModelState.IsValid)
            {
                db.Ilmastointi.Add(ilmastointi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ilmastointi);
        }

        // GET: Ilmastointi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilmastointi ilmastointi = db.Ilmastointi.Find(id);
            if (ilmastointi == null)
            {
                return HttpNotFound();
            }
            return View(ilmastointi);
        }

        // POST: Ilmastointi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IlmastointiId,IlmastoinninTila,TavoiteLampo,HuoneId")] Ilmastointi ilmastointi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ilmastointi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ilmastointi);
        }

        // GET: Ilmastointi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilmastointi ilmastointi = db.Ilmastointi.Find(id);
            if (ilmastointi == null)
            {
                return HttpNotFound();
            }
            return View(ilmastointi);
        }

        // POST: Ilmastointi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ilmastointi ilmastointi = db.Ilmastointi.Find(id);
            db.Ilmastointi.Remove(ilmastointi);
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
