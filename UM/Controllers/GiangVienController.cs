using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UM.Models;

namespace UM.Controllers
{
    public class GiangVienController : Controller
    {
        // GET: GiangVien
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

    }
}