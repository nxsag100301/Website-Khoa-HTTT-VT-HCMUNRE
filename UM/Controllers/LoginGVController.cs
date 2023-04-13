using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UM.Models;

namespace UM.Controllers
{
    public class LoginGVController : Controller
    {
        // GET: LoginGV
        public ActionResult Login(login li)
        {
            return View(li);
        }
        public ActionResult Loginsearch(login li)
        {
            EDUCATIONDataContext context = new EDUCATIONDataContext();
            LoginGV loginGV = context.LoginGVs.FirstOrDefault(x => Equals(x.MaLogin, li.malogin));
            if (loginGV != null)
            {
                if (li.password == loginGV.Password)
                {
                    //FormsAuthentication.SignOut();
                    //Session.Clear();
                    //Session["MaLogin"] = loginGVK.MaLogin;
                    //FormsAuthentication.SetAuthCookie(loginGVK.ROLE.ToString(), true);
                    return RedirectToAction("Index", "TinTuc"); //sửa GIAOVIEN
                }
                else
                {
                    ViewBag.message = "Sai tên tài khoản hoặc mật khẩu";
                    return View("Login");
                }
            }

            return View("Login");

        }
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return View("Login");
        }
    }
}