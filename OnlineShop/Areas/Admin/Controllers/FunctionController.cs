using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framwork;
using Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class FunctionController : Controller
    {
        // GET: Admin/Function
        public ActionResult Index()
        {
            List<Function> functions = new FunctionModel().GetAll();
            return View(functions);
        }
    }
}