
using NHOM7.Models.bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using SOFTWARE_ENGINEER123;

namespace NHOM7.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult Index()
        {
            var ds = thongtinkh.DanhSach();
            return View(ds);
        }
    }
}