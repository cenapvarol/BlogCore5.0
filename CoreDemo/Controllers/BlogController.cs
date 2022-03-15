using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        //public IActionResult BlogDetails(int id)
        //{
        //    ViewBag.id = id;
        //    var values = bm.GetById(id);
        //    return View(values);

        //}
        public IActionResult BlogListDetails(int id)
        {
            ViewBag.id = id;
            var values = bm.GetBlogID(id);
            

            return View(values);

        }
        public IActionResult BlogListByWriter()
        {
            var userMail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBm(writerID);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
           
            List<SelectListItem> categoryvalues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidatior bw = new BlogValidatior();
            ValidationResult results = bw.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriteID = 1;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }


            return View();
        }
        public IActionResult BlogDelete(int id)
        {
            var values = bm.GetById(id);

            //bm.TDelete(values);
            values.BlogStatus = false;
            bm.TUpdate(values);

            return RedirectToAction("BlogListByWriter", "Blog");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            var values = bm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            p.BlogStatus = true;
            p.WriteID = p.WriteID;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter","Blog");
        }
    }
}
