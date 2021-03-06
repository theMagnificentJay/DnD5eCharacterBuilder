using DnD5eCharacterBuilder.Data;
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
    [Authorize]
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CharacterService(userId);
            var model = service.GetCharacters();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharacterCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateCharacterService();

            if (service.CreateCharacter(model))
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        private CharacterService CreateCharacterService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CharacterService(userId);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateCharacterService();
            var model = svc.GetCharacterById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateCharacterService();
            var detail = service.GetCharacterById(id);
            var model =
                new CharacterEdit
                {
                    CharacterId = detail.CharacterId,
                    CharacterName = detail.CharacterName,
                    CharacterSex = detail.CharacterSex,
                    CharacterRace = detail.CharacterRace,
                    CharacterClass = detail.CharacterClass,
                    Xp = detail.Xp,
                    PlayerName = detail.PlayerName
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CharacterEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CharacterId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateCharacterService();

            if (service.UpdateCharacter(model))
            {
                TempData["Save Result"] = "Character updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Something went wrong.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateCharacterService();
            var model = svc.GetCharacterById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateCharacterService();

            service.DeleteCharacter(id);

            TempData["Save Result"] = "Character deleted.";

            return RedirectToAction("Index");
        }
    }
}