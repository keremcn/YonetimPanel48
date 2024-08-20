using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YonetimPanel48.Models;

namespace YonetimPanel48.Areas.Yonetim.Controllers
{
    public class TBL_KULLANICIController : Controller
    {
        private YonetimPanel48Entities db = new YonetimPanel48Entities();

        // GET: Yonetim/TBL_KULLANICI
        public ActionResult Index()
        {
            return View(db.TBL_KULLANICI.ToList());
        }

        // GET: Yonetim/TBL_KULLANICI/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_KULLANICI tBL_KULLANICI = db.TBL_KULLANICI.Find(id);
            if (tBL_KULLANICI == null)
            {
                return HttpNotFound();
            }
            return View(tBL_KULLANICI);
        }

        // GET: Yonetim/TBL_KULLANICI/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yonetim/TBL_KULLANICI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "K_ID,K_ADI,K_PAROLA")] TBL_KULLANICI tBL_KULLANICI)
        {
            if (ModelState.IsValid)
            {
                db.TBL_KULLANICI.Add(tBL_KULLANICI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_KULLANICI);
        }

        // GET: Yonetim/TBL_KULLANICI/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_KULLANICI tBL_KULLANICI = db.TBL_KULLANICI.Find(id);
            if (tBL_KULLANICI == null)
            {
                return HttpNotFound();
            }
            return View(tBL_KULLANICI);
        }

        // POST: Yonetim/TBL_KULLANICI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "K_ID,K_ADI,K_PAROLA")] TBL_KULLANICI tBL_KULLANICI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_KULLANICI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_KULLANICI);
        }

        // GET: Yonetim/TBL_KULLANICI/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_KULLANICI tBL_KULLANICI = db.TBL_KULLANICI.Find(id);
            if (tBL_KULLANICI == null)
            {
                return HttpNotFound();
            }
            return View(tBL_KULLANICI);
        }

        // POST: Yonetim/TBL_KULLANICI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_KULLANICI tBL_KULLANICI = db.TBL_KULLANICI.Find(id);
            db.TBL_KULLANICI.Remove(tBL_KULLANICI);
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
