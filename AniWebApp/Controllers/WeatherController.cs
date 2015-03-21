﻿using System;
using System.Linq;
using System.Web.Mvc;
using AniWebApp.Models;

namespace AniWebApp.Controllers
{
    [Route("Weather")]
    public class WeatherController : Controller
    {
         
        private readonly AniEntities _entities = new AniEntities();
        
        /// <summary>
        /// Gets data for the weather forecasts page.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route(@"Weather/Forecasts")]
        public ActionResult Forecasts()
        {
            // TODO: Grab this from the current user's profile
            const int ZipCode = 43035;

            var predictions = _entities.ActiveWeatherPredictionsSelect(ZipCode).ToList();
            return View(predictions);
        }

        /// <summary>
        /// Gets data for the weather forecasts page.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route(@"Weather/Frost")]
        public ActionResult Frost()
        {
            var predictions = _entities.WeatherFrostPredictionsVsActualsSelect().ToList();
            return View(predictions);
        }
        
        [HttpGet]
        [Route(@"Weather/Frost/AddEntry")]
        public ActionResult AddFrostEntry()
        {
            // TODO: Require authorize

            var model = new AddFrostRecordModel
            {
                RecordDate = DateTime.Today,
                ZipCode = 43035,
                ActualMinutes = 0.0
            };
            // TODO: This should use something from the user's settings instead

            return View(model);
        }

        [HttpPost]
        [Route(@"Weather/Frost/AddEntry")]
        [ValidateAntiForgeryToken]
        public ActionResult AddFrostEntry_Push(AddFrostRecordModel entry)
        {
            // TODO: Require authorize

            // TODO: Grab this from the current user!
            const int userID = 1;

            var result = _entities.WeatherFrostResultsInsert(userID,
                entry.RainedOvernight,
                entry.ActualMinutes,
                entry.ZipCode,
                entry.RecordDate.Date);

            // On success, go back to the list page
            if (result >= 1)
            {
                return RedirectToAction("Frost");
            }

            // We're not quite valid. Redirect to the view
            return View(entry);
        }
    }
}