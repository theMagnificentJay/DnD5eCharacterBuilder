using DnD5eCharacterBuilder.Models;
using DnD5eCharacterBuilder.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD5eCharacterBuilder.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new StatisticService(userId);
            var model = service.GetStatistics();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StatisticCreate model, int id)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateStatisticService();

            if (service.CreateStatistic(model, id))
            {
                return View("~/Views/Home/Index.cshtml");
            }

            return View(model);
        }

        private StatisticService CreateStatisticService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new StatisticService(userId);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateStatisticService();
            var model = svc.GetStatisticById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateStatisticService();
            var detail = service.GetStatisticById(id);
            var model =
                new StatisticEdit
                {
                    CharacterStatisticId = detail.CharacterStatisticId,
                    Strength = detail.Strength,
                    Dexterity = detail.Dexterity,
                    Constitution = detail.Constitution,
                    Intelligence = detail.Intelligence,
                    Wisdom = detail.Wisdom,
                    Charisma = detail.Charisma
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StatisticEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CharacterStatisticId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateStatisticService();

            if (service.UpdateStatistic(model))
            {
                TempData["Save Result"] = "Character updated.";
                return View("~/Views/Home/Index.cshtml");
            }

            ModelState.AddModelError("", "Something went wrong.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateStatisticService();
            var model = svc.GetStatisticById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateStatisticService();

            service.DeleteStatistic(id);

            TempData["Save Result"] = "Character statistics deleted.";

            return RedirectToAction("Index");
        }
    }
}