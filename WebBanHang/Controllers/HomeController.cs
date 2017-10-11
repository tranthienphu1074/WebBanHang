using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        DefaultConnectionEntities db = new DefaultConnectionEntities();
        public ActionResult Index()
        {
            string Chuoi = "";
            var product = (from p in db.DanhMucs orderby p.ID ascending select p).Take(12).ToList();
            for(int i = 0; i<product.Count; i++)
            {
               Chuoi += "<div class=\"pro-item\">";
               Chuoi += "<img src=\""+ product[i].Image +"\"/><br/>";
               Chuoi += "<a href=\"#\">" + product[i].TenSanPham + "</a>";
               Chuoi += "</div>";
            }
            ViewBag.view = Chuoi;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}