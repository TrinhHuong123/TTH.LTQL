using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TTH.LTQL.Models;

namespace TTH.LTQL.Controllers
{
    public class TRINHDO_CMsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TRINHDO_CMs
        public ActionResult Index()
        {
            return View(db.TRINHDO_CMs.ToList());
        }

        // GET: TRINHDO_CMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_CM tRINHDO_CM = db.TRINHDO_CMs.Find(id);
            if (tRINHDO_CM == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_CM);
        }

        // GET: TRINHDO_CMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRINHDO_CMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STT,TenNV,MaNV,TDCM,TDNN")] TRINHDO_CM tRINHDO_CM)
        {
            if (ModelState.IsValid)
            {
                db.TRINHDO_CMs.Add(tRINHDO_CM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRINHDO_CM);
        }

        // GET: TRINHDO_CMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_CM tRINHDO_CM = db.TRINHDO_CMs.Find(id);
            if (tRINHDO_CM == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_CM);
        }

        // POST: TRINHDO_CMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STT,TenNV,MaNV,TDCM,TDNN")] TRINHDO_CM tRINHDO_CM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRINHDO_CM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRINHDO_CM);
        }

        // GET: TRINHDO_CMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRINHDO_CM tRINHDO_CM = db.TRINHDO_CMs.Find(id);
            if (tRINHDO_CM == null)
            {
                return HttpNotFound();
            }
            return View(tRINHDO_CM);
        }

        // POST: TRINHDO_CMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRINHDO_CM tRINHDO_CM = db.TRINHDO_CMs.Find(id);
            db.TRINHDO_CMs.Remove(tRINHDO_CM);
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
