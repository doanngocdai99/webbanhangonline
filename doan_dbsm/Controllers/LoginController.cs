using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using doan_dbsm.Models.DATA;
using EO.Internal;

namespace doan_dbsm.Controllers
{
    public class LoginController : Controller
    {
        SHOPONLINE_CONTEXT db = new SHOPONLINE_CONTEXT();

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CUSTUMER custumer)
        {

            ViewBag.thongbao = "them tai khoan thanh cong";
            db.CUSTUMERs.Add(custumer);


            db.SaveChanges();
            //co the lay bang form conection 
            return View();

        }
        [HttpPost]
        public ActionResult dangnhap(FormCollection f)

        {
            string name = f["name"].ToString();
            string pass = f["pass"].ToString();
            if (f["customer"] != null)
            {
                CUSTUMER tv = db.CUSTUMERs.SingleOrDefault(n => n.name == name && n.pass == pass);
                if (tv != null)
                {
                    Session["taikhoan"] = tv.name;
                    Session["taikhoanid"] = tv.custumerid;
                    return RedirectToAction("Index", "Home");
                }
            }
            else if (f["admin"] != null)
            {
                ADMIN tv = db.USERs.SingleOrDefault(n => n.name == name && n.pass == pass);
                if (tv != null)
                {
                    Session["taikhoanad"] = tv.name;
                    Session["taikhoanidad"] = tv.adminid;
                    return RedirectToAction("Index", "quanlysanpham", new { area = "admin" });
                }

            }


            return View();
        }
        public ActionResult dangxuat(FormCollection f)

        {

            Session["taikhoan"] = null;
            Session["taikhoanid"] = null;


            return RedirectToAction("Index", "Home");
        }
        public ActionResult quenmatkhau()
        {


            //CUSTUMER cus = new CUSTUMER();
            //cus = _db.cus.SingleOrDefault(n => n.Email == email); db.CUSTUMERs.SingleOrDefault
            //cus.Password = "dsksjivlais";
            //string pass = cus.Password;
            //_db.SaveChanges();
            //GuiEmail("Thong Bao", email, "Phamtobao99@gmail.com", "17110261", "Your new password:" + pass);
            //return Redirect("index");
            return View();

        }

        public ActionResult postquenmatkhau(string email)
        {


            CUSTUMER cus = new CUSTUMER();
            cus = db.CUSTUMERs.SingleOrDefault(n => n.email == email);
            cus.pass = "abc123";
            string pass = cus.pass;
            db.SaveChanges();
            GuiEmail("Thong Bao", email, "doanngocdai99@gmail.com", "ngocdai300699", "Your new password:" + pass);



            return RedirectToAction("index");

        }

        public ActionResult viewdoimatkhau(string email)
        {


            return View();
        }


        public void GuiEmail(string Title, string ToEmail, string FromEmail, string PassWord, string Content)
        {
            // goi email
            MailMessage mail = new MailMessage();
            mail.To.Add(ToEmail); // Địa chỉ nhận
            mail.From = new MailAddress(ToEmail); // Địa chửi gửi
            mail.Subject = Title; // tiêu đề gửi
            mail.Body = Content; // Nội dung
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; // host gửi của Gmail
            smtp.Port = 587; //port của Gmail
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            (FromEmail, PassWord);//Tài khoản password người gửi
            smtp.EnableSsl = true; //kích hoạt giao tiếp an toàn SSL
            smtp.Send(mail); //Gửi mail đi
        }
    }
}