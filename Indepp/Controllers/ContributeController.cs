﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepp.Models;
using Indepp.DAL;
using System.Data;
using Indepp.Filters;
using Indepp.HelperMethods;

namespace Indepp.Controllers
{
    public class ContributeController : Controller
    {
        public PlaceContext Context;
        public ViewBagHelperMethods ViewBagHelpers;

        public ContributeController(PlaceContext context)
        {
            Context = context;
            ViewBagHelpers = new ViewBagHelperMethods();
        }
        // GET: UserPlace
        public ActionResult CreatePlace()
        {
            var workingHours = new WorkingHour();
            var place = new Place() { WorkingHours = workingHours.PopulateHours() };
            ViewBag.AvailableCategories = ViewBagHelpers.PopulatePlaceCategories();
            ViewBag.TopContributors = ViewBagHelpers.GetTopContributors(Context, 10);

            if (TempData["PlaceConfirmed"] != null)
                return View(TempData["PlaceConfirmed"] as Place);

            return View(place);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePlace(Place place)
        {
            if (ModelState.IsValid)
            {
                TempData.Add("Place", place);
                return RedirectToAction("PreviewPlace");
            }

            ViewBag.AvailableCategories = ViewBagHelpers.PopulatePlaceCategories();
            ViewBag.TopContributors = ViewBagHelpers.GetTopContributors(Context, 10);
            return View(place);
        }

        [HttpGet]
        public ActionResult PreviewPlace()
        {
            var place = TempData["Place"] as Place;
            TempData.Add("PlaceConfirmed", place);

            return View(place);
        }

        [HttpPost]
        [Throttle(Message = "You must wait {n} minutes before you can contribute another place.", Seconds = 20)]
        public ActionResult SubmitPlace()
        {
            var place = TempData["PlaceConfirmed"] as Place;
            try
            {
                if (ModelState.IsValid)
                {
                    place.UserContributed = true;
                    place.Reviewed = false;
                    Context.Places.Add(place);
                    Context.SaveChanges();

                    return View();
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to add a place. Try again, and if the problem persists see your system administrator.");
                ViewBag.Error = "We were unable to save your place, please try again later or contact administrator";
            }

            return View();
        }
    }
}