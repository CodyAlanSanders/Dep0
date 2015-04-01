using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotDogLover.Models;
using HotDogLover.Service;

namespace HotDogLover.Controllers
{
    public class ProfileController : Controller
    {
        ProfileService profileService = new ProfileService();

        // GET: Profile
        public ActionResult Index()
        {
            return View(profileService.ListAll());
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            HotDogLover.Models.Profile profile = profileService.Get(id);
            return View(profile);
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View(profileService.Get(id));
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, FirstName, LastName, Bio, ImageUrl")]Profile profile)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", new { id = profile.Id });
            }
            try
            {
                profileService.Update(profile);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateHotdog(int id)
        {
            ViewBag.profileID = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddHotdog(int profileID, [Bind(Include = "Name, LastAte, LastEaten, Rating")]Hotdogs dog)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "Please check your form and resubmit";
                return RedirectToAction("CreateDog");
            }
            try
            {
                profileService.AddDog(new Profile() { Id = profileID }, dog);
                return RedirectToAction("Details", new { id = profileID });
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Profile/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
