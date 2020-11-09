using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using btlMVC01.Models;

namespace btlMVC01.Controllers
{
    public class SANPHAMsAdminController : Controller
    {
        private btlEntities db = new btlEntities();

        // GET: SANPHAMsAdmin
        public ActionResult Index()
        {
            var sANPHAM = db.SANPHAM.Include(s => s.LOAISANPHAM);
            return View(sANPHAM.ToList());
        }
        public ActionResult Suasp()
        {
            var sANPHAM = db.SANPHAM.Include(s => s.LOAISANPHAM);
            return View(sANPHAM.ToList());
        }
        public ActionResult XoaSP()
        {
            var sANPHAM = db.SANPHAM.Include(s => s.LOAISANPHAM);
            return View(sANPHAM.ToList());
        }

        // GET: SANPHAMsAdmin/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: SANPHAMsAdmin/Create
        public ActionResult Create()
        {
            ViewBag.maloaisp = new SelectList(db.LOAISANPHAM, "maloaisp", "tenloaisp");
            return View();
        }

        // POST: SANPHAMsAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "masp,tensp,Mota,hinhanh,gia,soluong,maloaisp")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.SANPHAM.Add(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maloaisp = new SelectList(db.LOAISANPHAM, "maloaisp", "tenloaisp", sANPHAM.maloaisp);
            return View(sANPHAM);
        }

        // GET: SANPHAMsAdmin/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            ViewBag.maloaisp = new SelectList(db.LOAISANPHAM, "maloaisp", "tenloaisp", sANPHAM.maloaisp);
            return View(sANPHAM);
        }

        // POST: SANPHAMsAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "masp,tensp,Mota,hinhanh,gia,soluong,maloaisp")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sANPHAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maloaisp = new SelectList(db.LOAISANPHAM, "maloaisp", "tenloaisp", sANPHAM.maloaisp);
            return View(sANPHAM);
        }

        // GET: SANPHAMsAdmin/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // POST: SANPHAMsAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SANPHAM sANPHAM = db.SANPHAM.Find(id);
            db.SANPHAM.Remove(sANPHAM);
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
