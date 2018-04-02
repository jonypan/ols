using Models.Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class UserController : BaseController<Category>
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
    }
}