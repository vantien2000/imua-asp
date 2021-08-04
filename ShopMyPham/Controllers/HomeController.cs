using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMyPham.Models;

namespace ShopMyPham.Controllers
{
    public class HomeController : Controller
    {
        private Nhom8DB db = new Nhom8DB();
        public ActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.DanhMuc = db.DanhMuc.Select(x => x).ToList();
            model.TinTuc = db.TinTuc.Select(x => x).ToList();
            model.SanPhamHot = db.SanPham.OrderBy(x => x.TenSP).ToList();

            return View(model);
        }

        [ChildActionOnly]
        public ActionResult DanhMuc()
        {
            var danhMuc = db.DanhMuc.Select(x => x);
            
            return PartialView("_MenuBar",danhMuc);
        }

        [ChildActionOnly]
        public ActionResult LoaiSP(int? id)
        {
            var loaiSanPham = db.LoaiSP.Where(w => w.MaDM == id).Select(x => x);
            return PartialView("LoaiSP",loaiSanPham);
        }

        [ChildActionOnly]
        public ActionResult LoaiSanPham(int? id)
        {
            var loaiSanPham = db.LoaiSP.Where(w => w.MaDM == id).Select(x => x);
            return PartialView("LoaiSanPham", loaiSanPham);
        }

        [ChildActionOnly]
        public ActionResult SanPham(int? id)
        {
            var sanPham = from sp in db.SanPham
                          join loai in db.LoaiSP
                          on sp.MaLoai equals loai.MaLoai
                          join dm in db.DanhMuc
                          on loai.MaDM equals dm.MaDM
                          where loai.MaDM == id
                          select sp;
            return PartialView("SanPham", sanPham);
        }

        public ActionResult Error()
        {
            return View("Error");
        }
    }
}