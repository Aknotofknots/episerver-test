using EPiServer.Web.Mvc;
using EPIserverTestSite.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPIserverTestSite.Controllers
{
    // this controller is created to manage the start page
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currentPage) // the currentPage argument binds the controller and the startpage together
        {
            return View();
        }
    }
}