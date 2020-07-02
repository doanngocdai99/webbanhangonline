using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan_dbsm.Models.DATA;

namespace doan_dbsm.Controllers
{
    
    public class HomeController : Controller
    {
        SHOPONLINE_CONTEXT db = new SHOPONLINE_CONTEXT();
        public ActionResult Index()
        {
            var list = db.PRODUCTs.ToList();
            var list2 = db.PRODUCTs.Where(a => a.product_id > 10);
            var listmen = db.PRODUCTs.Where(a => a.PRODUCT_GROUP.gr_groupname == "Men");
            ViewBag.list = list;
            ViewBag.list2 = list2;
            return View();
        }
        public ActionResult MainMenu ()
        {
            return PartialView();
        }
        public ActionResult HeaderIcon()
        {
            return PartialView();
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}