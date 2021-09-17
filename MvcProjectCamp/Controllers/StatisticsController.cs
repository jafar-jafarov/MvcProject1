using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        // GET: Statistics
        public ActionResult Index()
        {
            //umumi kateqori sayisi
            var value1 = context.Categories.Count().ToString();
            ViewBag.value1 = value1;

            var value2 = context.Headings.Count(x => x.CategoryId == 32).ToString() ;
            ViewBag.value2 = value2;

            var value3 = context.Writers.Where(x => x.WriterName.Contains("a") || x.WriterName.Contains("A")).Count();
            ViewBag.value3 = value3;

            var value4 = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.value4 = value4;
           // var value4 = context.Categories.Where(a => a.CategoryId == context.Headings.GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count())
            //   .Select(x =>x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
           // ViewBag.value4 = value4;

            //   var value4=context.Headings.Where(x=>x.cate)
            var value5 = context.Categories.Where(n => n.CategoryStatus == true).Count() - context.Categories.Where(n => n.CategoryStatus == false).Count();
            ViewBag.value5 = value5;
            return View();
        }
    }
}