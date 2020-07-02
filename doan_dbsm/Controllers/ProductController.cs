using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan_dbsm.Models.DATA;
namespace doan_dbsm.Controllers
{
    public class ProductController : Controller
    {
        SHOPONLINE_CONTEXT db = new SHOPONLINE_CONTEXT();
        // GET: Product
        public ActionResult productpartialview()
        {
            var list = db.PRODUCTs.ToList();
            //var lstproduct1 =  db.PRODUCTs.ToString();
            //ViewBag.lstproduct1 = lstproduct1;
            return PartialView();
        }
        public ActionResult productpartialview2()
        {
            var list = db.PRODUCTs.ToList();
            return PartialView(list);
        }
        public ActionResult Index()

        {

            var list = db.PRODUCTs.ToList();
            ViewBag.list2 = list;
        
            return View();
        }
        public ActionResult Product_detail()
        {
            return View();
        }
        public ActionResult Product_details(int Masp)
        {
            var Product = db.PRODUCTs.SingleOrDefault(n => n.product_id == Masp);
            ViewBag.list5 = Product;
            return View();
        }

        public ActionResult Grproduct (string id)
        {
            var gr_product = db.PRODUCTs.Where(a => a.PRODUCT_GROUP.gr_groupname == id&&a.product_id>10).ToList();
            ViewBag.gr_product = gr_product;
            return View();
        }
    }
}