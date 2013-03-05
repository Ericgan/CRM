using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.IDALServices;
using CRM.Model;

namespace CRM.Web.Controllers
{
    public class HomeController : Controller
    {
        ICRMService service;

        public HomeController(ICRMService service)
        {
            this.service = service;
        }

        //
        // GET: /PkgOrder/

        public ActionResult Index()
        {
            var pkgOrders = service.GetPkgOrders().Take(20);
            return View(pkgOrders);
        }

    }
}
