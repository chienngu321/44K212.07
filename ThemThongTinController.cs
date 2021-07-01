using SOFTWARE_ENGINEER123;
using NHOM7.Models.bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHOM7.Controllers
{
    public class ThemThongTinController : Controller
    {
        // GET: ThemThongTin
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThemThongTin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThemThongTin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThemThongTin/Create
        [HttpPost]
        public ActionResult Create(ThongTinKhachHang ttkh)
        {
            try
            {
                // TODO: Add insert logic here
                thongtinkh.ThemTTKH(ttkh);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ThemThongTin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThemThongTin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ThemThongTin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThemThongTin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
