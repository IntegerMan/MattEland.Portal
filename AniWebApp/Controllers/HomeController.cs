﻿using System.Web.Mvc;

namespace AniWebApp.Controllers
{
    /// <summary>
    /// An MVC Controller controlling the application root.
    /// </summary>
    public class HomeController : CustomController
    {
        /// <summary>
        /// Serves up the home page
        /// </summary>
        /// <returns>The home page view</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Serves up the about me page
        /// </summary>
        /// <returns>The about me view.</returns>
        public ActionResult AboutMe()
        {
            return View();
        }
    }
}
