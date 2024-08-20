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
    public class TBL_HABERController : Controller
    {
        private YonetimPanel48Entities db = new YonetimPanel48Entities();

        // GET: Yonetim/TBL_HABER
        public ActionResult Index()
        {
            return View(db.TBL_HABER.ToList());
        }

        // GET: Yonetim/TBL_HABER/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_HABER tBL_HABER = db.TBL_HABER.Find(id);
            if (tBL_HABER == null)
            {
                return HttpNotFound();
            }
            return View(tBL_HABER);
        }

        // GET: Yonetim/TBL_HABER/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yonetim/TBL_HABER/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "H_ID,P_BASLIK,P_ICERIK")] TBL_HABER tBL_HABER)
        {
            if (ModelState.IsValid)
            {
                db.TBL_HABER.Add(tBL_HABER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_HABER);
        }

        // GET: Yonetim/TBL_HABER/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_HABER tBL_HABER = db.TBL_HABER.Find(id);
            if (tBL_HABER == null)
            {
                return HttpNotFound();
            }
            return View(tBL_HABER);
        }

        // POST: Yonetim/TBL_HABER/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "H_ID,P_BASLIK,P_ICERIK")] TBL_HABER tBL_HABER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_HABER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_HABER);
        }

        // GET: Yonetim/TBL_HABER/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_HABER tBL_HABER = db.TBL_HABER.Find(id);
            if (tBL_HABER == null)
            {
                return HttpNotFound();
            }
            return View(tBL_HABER);
        }

        // POST: Yonetim/TBL_HABER/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_HABER tBL_HABER = db.TBL_HABER.Find(id);
            db.TBL_HABER.Remove(tBL_HABER);
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
