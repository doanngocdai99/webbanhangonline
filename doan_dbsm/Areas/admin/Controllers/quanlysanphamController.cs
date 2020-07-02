using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan_dbsm.Models.DATA;

namespace doan_dbsm.Areas.admin.Controllers
{

    public class quanlysanphamController : Controller
    {
        SHOPONLINE_CONTEXT db = new SHOPONLINE_CONTEXT();

        // GET: admin/quanlysanpham
        public ActionResult Index()
        {
            return View(db.PRODUCTs.ToList());
        }
       
        [HttpGet]
        public ActionResult taomoi()
        {

            return View();
        }
        [HttpPost]
        public ActionResult taomoi(HttpPostedFileBase hinhanh,PRODUCT sp,string gr_groupid)
        {
            if (hinhanh!=null)
            {
                var filename = Path.GetFileName(hinhanh.FileName);
                var path = Path.Combine(Server.MapPath("~/images"), filename);
                hinhanh.SaveAs(path);
                sp.image = hinhanh.FileName;
            }
           
            if (gr_groupid=="Man")
            {
                sp.gr_groupid = 1;
            }
            else
            {
                sp.gr_groupid = 2;
            }
            
            db.PRODUCTs.Add(sp);
            db.SaveChanges();
            return Redirect("Index");
        }
        [HttpGet]
        public ActionResult edit(int product_id)
        {
            PRODUCT sp = db.PRODUCTs.SingleOrDefault(n=>n.product_id==product_id);
            if (sp==null)
            {
                return HttpNotFound();
            }

            return View(sp);
        }
        [HttpPost]
        public ActionResult edit(HttpPostedFileBase hinhanh, PRODUCT sp, string gr_groupid)
        {
            PRODUCT spedit = db.PRODUCTs.Find(sp.product_id);
            
            if (hinhanh != null)
            {
                var filename = Path.GetFileName(hinhanh.FileName);
                var path = Path.Combine(Server.MapPath("~/images"), filename);
                hinhanh.SaveAs(path);
                spedit.image = hinhanh.FileName;
            }

            if (gr_groupid == "Man")
            {
                spedit.gr_groupid = 1;
            }
            else
            {
                spedit.gr_groupid = 2;
            }
           
            spedit.product_Name = sp.product_Name;
            spedit.Description = sp.Description;
            spedit.count = sp.count;
            db.SaveChanges();
            return Redirect("Index");

            
        }
        public ActionResult delete(int product_id)
        {
            PRODUCT sp = db.PRODUCTs.SingleOrDefault(n => n.product_id == product_id);
            if (sp == null)
            {
                return HttpNotFound();
            }
            db.PRODUCTs.Remove(sp);
            db.SaveChanges();
            return Redirect("Index");
        }
        public ActionResult details(int product_id)
        {
            PRODUCT sp = db.PRODUCTs.SingleOrDefault(n => n.product_id == product_id);
            if (sp == null)
            {
                return HttpNotFound();
            }
            db.PRODUCTs.Remove(sp);
            db.SaveChanges();
            return Redirect("Index");
        }
        public ActionResult search (string search)
        {
            ViewBag.search = search;
            List<PRODUCT> lstsearch = db.PRODUCTs.Where(a => a.product_Name.Contains(search)).ToList();
          
            return View("Index",lstsearch);
        }
    }
}