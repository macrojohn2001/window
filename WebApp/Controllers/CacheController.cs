using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CacheController : Controller
    {
        // GET: Cache
        public ActionResult Index()
        {
            
            this.HttpContext.Cache["table"] = "Part";
           
            return View();
        }
    }
}