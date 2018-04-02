using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Areas.Admin.Code;
using System.Web.Security;
using Models.Models;
using Models;
using OnlineShop.Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel loginModel)
        {
            int UserID = new UserModel().Login(loginModel.Username,Encryptor.GetMD5(loginModel.Password));
            if(UserID > 0 && ModelState.IsValid) //Membership.ValidateUser(loginModel.Username,loginModel.Password)
            {
                //SessionHelper.SetSession(new UserSession() { Username = loginModel.Username });
                UserSession usersession = new UserSession() { Username = loginModel.Username };
                List<Menu> menu = new FunctionModel().GetMenu(UserID);
                usersession.menu = menu;
                SessionHelper.SetSession(usersession);
                FormsAuthentication.SetAuthCookie(loginModel.Username,loginModel.Rememberme);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập sai.");
            }
            return View(loginModel);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}