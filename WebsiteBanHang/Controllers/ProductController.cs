using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class ProductController : Controller
    {
        WebsiteBanHangEntities objWebsiteBanHangEntities = new WebsiteBanHangEntities();

        // GET: Product
        public ActionResult Detail( int Id)
        {
            var objProduct = objWebsiteBanHangEntities.Products.Where(n => n.Id == Id).FirstOrDefault();
            return View(objProduct);
        }
        public ActionResult List( int Id)
        {
            var ListProduct = objWebsiteBanHangEntities.Products.Where(n => n.CategoryId == Id).ToList();
                return View(ListProduct);
        }
    }
}