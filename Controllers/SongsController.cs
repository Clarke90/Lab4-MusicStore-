using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week11.Controllers
{
    public class SongsController : Controller
    {

        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Songs/Browse
        public ActionResult Browse()
        {
            // create array of hard-coded genres
            var songs = new string[] { "You Shook Me", "King Of Pain", "City of Blinding Lights" };

            ViewBag.songs = songs;
            return View();
        }
    }
}