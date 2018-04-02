using Models;
using Models.Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using PagedList;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class CategoryController : BaseController<Category>
    {
        public CategoryController() : base("Category")
        {

        }
        // GET: Admin/Category
        public ActionResult Index(int page = 1, int pageSize = 3)
        {
      
            var iplCategory = new CategoryModel();
            var listCategory = iplCategory.GetAll().ToPagedList(page, pageSize);
            return View(listCategory);
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        //[HttpPost]
        //public ActionResult Create(Category category)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if(new CategoryModel().Insert(category)) //category.Name,category.MetaTitle,(category.ParentID == null ? 0 : (int)category.ParentID.Value
        //            {
        //                return RedirectToAction("Index");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Lỗi hệ thống!");
        //                return View(category);
        //            }

        //        }
        //        ModelState.AddModelError("", "Có lỗi!");
        //        return View(category);
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = new CategoryModel().GetByID(id);
            return View(category);
        }

        // POST: Admin/Category/Edit/5
        
        public override ActionResult EditRewrite(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (new CategoryModel().Edit(category)) //category.Name,category.MetaTitle,(category.ParentID == null ? 0 : (int)category.ParentID.Value
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Lỗi hệ thống!");
                        return View(category);
                    }

                }
                ModelState.AddModelError("", "Có lỗi!");
                return View(category);
            }
            catch
            {
                return View();
            }
        }

        // POST: Admin/Category/Delete/5
        
        public override ActionResult DeleteRewrite(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (new CategoryModel().Delete(category)) //category.Name,category.MetaTitle,(category.ParentID == null ? 0 : (int)category.ParentID.Value
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Lỗi hệ thống!");
                        return RedirectToAction("Index");
                    }

                }
                ModelState.AddModelError("", "Có lỗi!");
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public override ActionResult CreateRewrite(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (new CategoryModel().Insert(category)) //category.Name,category.MetaTitle,(category.ParentID == null ? 0 : (int)category.ParentID.Value
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Lỗi hệ thống!");
                        return View(category);
                    }

                }
                ModelState.AddModelError("", "Có lỗi!");
                return View(category);
            }
            catch
            {
                return View();
            }
        }
    }
}
