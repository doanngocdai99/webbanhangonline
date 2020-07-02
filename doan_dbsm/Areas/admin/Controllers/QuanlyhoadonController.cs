using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan_dbsm.Models.DATA;
namespace doan_dbsm.Areas.admin.Controllers
{
    public class QuanlyhoadonController : Controller
    {
        SHOPONLINE_CONTEXT db = new SHOPONLINE_CONTEXT();
        // GET: admin/Quanlyhoadon
        public ActionResult Index()
        {
            return View(db.ORDERs.ToList());
        }
        public ActionResult Bill(int madonhang)
        {
            List<DETAIL_ORDER> DetailOrder = db.DETAIL_ORDERs.Where(n => n.order_ID == madonhang).ToList();
            CUSTUMER tv = DetailOrder[0].ORDER.CUSTUMER;
            ViewBag.tenkhachhang = tv.name;
            ViewBag.thanhpho = tv.city;
            ViewBag.diachi = tv.adress;
            ViewBag.ngay = DetailOrder[0].ORDER.Datetime.Substring(0,10);
            return View(DetailOrder);
        }
        public ActionResult deleteorder(int madonhang)
        {
            ORDER sp = db.ORDERs.SingleOrDefault(n => n.order_ID == madonhang);
            if (sp == null)
            {
                return HttpNotFound();
            }
            db.ORDERs.Remove(sp);
            db.SaveChanges();
            return Redirect("Index");
        }
    }
}