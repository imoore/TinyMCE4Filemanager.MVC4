using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinyMCE4Filemanager.ViewModels;

namespace TinyMCE4Filemanager.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var url = HttpRuntime.AppDomainAppVirtualPath;
            return View(new HomeViewModel
                {
                    baseUrl = url
                });
        }

    }
}
