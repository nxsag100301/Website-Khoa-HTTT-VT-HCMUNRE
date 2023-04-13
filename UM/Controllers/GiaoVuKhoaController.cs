using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UM.Models;

namespace UM.Controllers
{
    public class GiaoVuKhoaController : Controller
    {
        // GET: GiaoVuKhoa
        public ActionResult IndexGVK()
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            List<GVKHOA> dsGIAOVUs = context.GVKHOAs.ToList();
            return View(dsGIAOVUs);
        }
        public ActionResult DetailsGVK(string magvk)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            GVKHOA GVK = context.GVKHOAs
                .FirstOrDefault(x => Equals(x.MaGVK, magvk));
            return View(GVK);
        }
        public ActionResult CreateGVK()
        {
            if (Request.Form.Count > 0)
            {
                String MaGVK = Request.Form["MaGVK"];
                String HotenGVK = Request.Form["HotenGVK"];
                DateTime NgaySinh = DateTime.Parse(Request.Form["NgaySinh"]);
                String Dienthoai = Request.Form["SDT"];
                String Diachi = Request.Form["Diachi"];
                String Gmail = Request.Form["Gmail"];
                String MaLH = Request.Form["MaLH"];
                EDUCATIONDataContext context = new EDUCATIONDataContext();
                GVKHOA GVK = new GVKHOA();
                GVK.MaGVK = MaGVK;
                GVK.HotenGVK = HotenGVK;
                GVK.Ngaysinh = NgaySinh;
                GVK.Dienthoai = Dienthoai;
                GVK.Diachi = Diachi;
                GVK.Gmail = Gmail;
                GVK.MaLH = MaLH;
                context.GVKHOAs.InsertOnSubmit(GVK);
                context.SubmitChanges();
                return RedirectToAction("IndexGVK");
            }
            return View();
        }
        public ActionResult EditGVK(string magvk)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            GVKHOA p = context.GVKHOAs.FirstOrDefault(x => x.MaGVK == magvk);
            if (Request.Form.Count == 0)
            {
                return View(p);
            }
            p.HotenGVK = Request.Form["HotenGVK"];
            p.Ngaysinh = DateTime.Parse(Request.Form["NgaySinh"]);
            p.Dienthoai = Request.Form["Dienthoai"];
            p.Diachi = Request.Form["Diachi"];
            p.Gmail = Request.Form["Gmail"];
            p.MaLH = Request.Form["MaLH"];
            context.SubmitChanges();
            return RedirectToAction("IndexGVK");
        }
        public ActionResult DeleteGVK(string magvk)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            GVKHOA GVK = context.GVKHOAs
                .FirstOrDefault(x => Equals(x.MaGVK, magvk));
            context.GVKHOAs.DeleteOnSubmit(GVK);
            context.SubmitChanges();
            return RedirectToAction("GVKHOA");
        }

        // GIANGVIEN
        public ActionResult IndexGV()
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            List<GIANGVIEN> dsGIANGVIENs = context.GIANGVIENs.ToList();
            return View(dsGIANGVIENs);
        }
        public ActionResult DetailsGV(string magv)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            GIANGVIEN GV = context.GIANGVIENs
                .FirstOrDefault(x => Equals(x.MaGV, magv));
            return View(GV);
        }
        public ActionResult CreateGV()
        {
            if (Request.Form.Count > 0)
            {

                String MaGV = Request.Form["MaGV"];
                String HotenGV = Request.Form["HotenGV"];
                DateTime NgaySinh = DateTime.Parse(Request.Form["NgaySinh"]);
                String Dienthoai = Request.Form["SDT"];
                String Diachi = Request.Form["Diachi"];
                String Gmail = Request.Form["Gmail"];
                String MaMH = Request.Form["MaMH"];
                String MaLH = Request.Form["MaLH"];
                EDUCATIONDataContext context = new EDUCATIONDataContext();
                GIANGVIEN GV = new GIANGVIEN();
                GV.MaGV = MaGV;
                GV.HotenGV = HotenGV;
                GV.Ngaysinh = NgaySinh;
                GV.Dienthoai = Dienthoai;
                GV.Diachi = Diachi;
                GV.Gmail = Gmail;
                GV.MaLH = MaLH;
                context.GIANGVIENs.InsertOnSubmit(GV);
                context.SubmitChanges();
                return RedirectToAction("IndexGV");
            }

            return View();
        }

        public ActionResult EditGV(string magv)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            GIANGVIEN v = context.GIANGVIENs.FirstOrDefault(x => x.MaGV == magv);
            if (Request.Form.Count == 0)
            {
                return View(v);
            }
            v.HotenGV = Request.Form["HotenGV"];
            v.Ngaysinh = DateTime.Parse(Request.Form["NgaySinh"]);
            v.Dienthoai = Request.Form["Dienthoai"];
            v.Diachi = Request.Form["DiaChi"];
            v.Gmail = Request.Form["Gmail"];
            v.MaMH = Request.Form["MaMH"];
            v.MaLH = Request.Form["MaLH"];
            context.SubmitChanges();
            return RedirectToAction("IndexGV"); //tên action
        }

        public ActionResult DeleteGV(string magv)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            GIANGVIEN GV = context.GIANGVIENs
                .FirstOrDefault(x => Equals(x.MaGV, magv));
            context.GIANGVIENs.DeleteOnSubmit(GV);
            context.SubmitChanges();
            return RedirectToAction("GIANGVIEN");
        }

        //HOCKY
        public ActionResult IndexHK()
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            List<HOCKY> dsHOCKYs = context.HOCKies.ToList();
            return View(dsHOCKYs);
        }
        public ActionResult DetailsHK(string mahk)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            HOCKY HK = context.HOCKies
                .FirstOrDefault(x => Equals(x.MaHK, mahk));
            return View(HK);
        }
        public ActionResult CreateHK()
        {
            if (Request.Form.Count > 0)
            {
                EDUCATIONDataContext context = new EDUCATIONDataContext();
                HOCKY HK = new HOCKY();
                HK.MaHK = Request.Form["MaHK"];
                HK.TenHK = Request.Form["TenHK"];
                HK.Tinchi = int.Parse(Request.Form["TinChi"]);
                HK.Sotiet = int.Parse(Request.Form["SoTiet"]);

                context.HOCKies.InsertOnSubmit(HK);
                context.SubmitChanges();
                // TODO: Add insert logic here

                return RedirectToAction("IndexHK");
            }
            return View();
        }

        public ActionResult EditHK(string mahk)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            HOCKY HK = context.HOCKies.FirstOrDefault(h => h.MaHK == mahk);
            if (Request.Form.Count == 0)
            {
                return View(HK);
            }
            HK.MaHK = Request.Form["MaHK"];
            HK.TenHK = Request.Form["TenHK"];
            HK.Tinchi = int.Parse(Request.Form["TinChi"]);
            HK.Sotiet = int.Parse(Request.Form["SoTiet"]);

            context.SubmitChanges();
            // TODO: Add insert logic here

            return RedirectToAction("IndexHK");
        }

        public ActionResult DeleteHK(string mahk)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            HOCKY HK = context.HOCKies
                .FirstOrDefault(x => Equals(x.MaHK, mahk));
            context.HOCKies.DeleteOnSubmit(HK);
            context.SubmitChanges();
            return RedirectToAction("IndexHK");
        }

        //LOPHOC
        public ActionResult IndexLH()
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            List<LOPHOC> dsLOPHOCs = context.LOPHOCs.ToList();
            return View(dsLOPHOCs);
        }
        public ActionResult DetailsLH(string malh)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            LOPHOC LH = context.LOPHOCs
                .FirstOrDefault(x => Equals(x.MaLH, malh));
            return View(LH);
        }
        public ActionResult CreateLH()
        {
            if (Request.Form.Count > 0)
            {
                EDUCATIONDataContext context = new EDUCATIONDataContext();
                LOPHOC LH = new LOPHOC();
                LH.MaLH = Request.Form["MaLH"];
                LH.TenLH = Request.Form["TenLH"];

                context.LOPHOCs.InsertOnSubmit(LH);
                context.SubmitChanges();
                // TODO: Add insert logic here

                return RedirectToAction("IndexHK");
            }
            return View();
        }
        public ActionResult EditLH(string malh)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            LOPHOC LH = context.LOPHOCs.FirstOrDefault(h => h.MaLH == malh);
            if (Request.Form.Count == 0)
            {
                return View(LH);
            }
            LH.MaLH = Request.Form["MaLH"];
            LH.TenLH = Request.Form["TenLH"];

            context.SubmitChanges();
            // TODO: Add insert logic here

            return RedirectToAction("IndexLH");
        }


        //MONHOC
        public ActionResult IndexMH()
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            List<MONHOC> dsMONHOCs = context.MONHOCs.ToList();
            return View(dsMONHOCs);
        }
        public ActionResult DetailsMH(string magmh)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            MONHOC MH = context.MONHOCs
                .FirstOrDefault(x => Equals(x.MaMH, magmh));
            return View(MH);
        }

        public ActionResult CreateMH()
        {
            if (Request.Form.Count > 0)
            {
                EDUCATIONDataContext context = new EDUCATIONDataContext();
                MONHOC MH = new MONHOC();
                MH.MaMH = Request.Form["MaHK"];
                MH.TenMH = Request.Form["TenHK"];
                MH.Tinchi = int.Parse(Request.Form["TinChi"]);
                MH.Sotiet = int.Parse(Request.Form["SoTiet"]);
                MH.MaHK = Request.Form["MaHK"];

                context.MONHOCs.InsertOnSubmit(MH);
                context.SubmitChanges();
                // TODO: Add insert logic here

                return RedirectToAction("IndexMH");
            }
            return View();
        }

        public ActionResult EditMH(string mamh)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            MONHOC MH = context.MONHOCs.FirstOrDefault(h => h.MaMH == mamh);
            if (Request.Form.Count == 0)
            {
                return View(MH);
            }
            MH.MaMH = Request.Form["MaMH"];
            MH.TenMH = Request.Form["TenMH"];
            MH.Tinchi = int.Parse(Request.Form["TinChi"]);
            MH.Sotiet = int.Parse(Request.Form["SoTiet"]);
            MH.MaHK = Request.Form["MaHK"];

            context.SubmitChanges();
            // TODO: Add insert logic here

            return RedirectToAction("IndexMH");
        }

        public ActionResult DeleteMH(string mamh)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            MONHOC MH = context.MONHOCs
                .FirstOrDefault(x => Equals(x.MaHK, mamh));
            context.MONHOCs.DeleteOnSubmit(MH);
            context.SubmitChanges();
            return RedirectToAction("IndexMH");
        }

        //TINTUC
        public ActionResult IndexTT()
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            List<TINTUC> dsTINTUCs = context.TINTUCs.ToList();
            return View(dsTINTUCs);

        }
        public ActionResult DetailsTT(string magtt)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            TINTUC TT = context.TINTUCs
                .FirstOrDefault(x => Equals(x.MaTT, magtt));
            return View(TT);
        }

        public ActionResult CreateTT()
        {
            if (Request.Form.Count > 0)
            {
                EDUCATIONDataContext context = new EDUCATIONDataContext();
                TINTUC TT = new TINTUC();
                TT.MaTT = Request.Form["MaTT"];
                TT.Tieude = Request.Form["Tieude"];
                TT.Ngaydang = DateTime.Parse(Request.Form["Ngaydang"]);
                TT.MaGVK = Request.Form["MaGVK"];

                context.TINTUCs.InsertOnSubmit(TT);
                context.SubmitChanges();
                // TODO: Add insert logic here

                return RedirectToAction("IndexTT");
            }
            return View();
        }

        public ActionResult EditTT(string matt)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            TINTUC TT = context.TINTUCs.FirstOrDefault(h => h.MaTT == matt);
            if (Request.Form.Count == 0)
            {
                return View(TT);
            }
            TT.MaTT = Request.Form["MaTT"];
            TT.Tieude = Request.Form["Tieude"];
            TT.Ngaydang = DateTime.Parse(Request.Form["Ngaydang"]);
            TT.MaGVK = Request.Form["MaGVK"];

            context.SubmitChanges();
            // TODO: Add insert logic here

            return RedirectToAction("IndexTT");
        }

        public ActionResult DeleteTT(string matt)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            TINTUC TT = context.TINTUCs
                .FirstOrDefault(x => Equals(x.MaTT, matt));
            context.TINTUCs.DeleteOnSubmit(TT);
            context.SubmitChanges();
            return RedirectToAction("IndexTT");
        }
    }
}