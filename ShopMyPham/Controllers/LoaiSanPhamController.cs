using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMyPham.Models;

namespace ShopMyPham.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSP
        private Nhom8DB db = new Nhom8DB();
        public ActionResult Index()
        {
            
            return View();
        }
        [ChildActionOnly]
        public ActionResult LoaiSPHome(int? madm)
        {
            var loaiSP = db.LoaiSP.Where(w => w.MaDM == madm).Select(x => x);
            return PartialView("LoaiSPHome",loaiSP);
        }
    }
}