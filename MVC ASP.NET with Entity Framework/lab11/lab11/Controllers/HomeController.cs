using lab11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11.Controllers
{
    public class HomeController : Controller
    {
        private Database1Entities1 _db = new Database1Entities1();

        public ActionResult Index()
        {
            var PerfumesWithTypes = (from perfume in _db.Perfume
                                   join perfumeType in _db.PerfumeTypes on perfume.TypeID equals perfumeType.TypeID
                                   select new PerfumeWithTypeViewModel
                                   {
                                       PerfumeID = perfume.PerfumeID,
                                       PerfumeName = perfume.PerfumeName,
                                       VolumeName = perfumeType.TypeName
                                   }).ToList();

            return View(PerfumesWithTypes);
        }




        public ActionResult Details(int id)
        {
            var perfume = _db.Perfume.Find(id);

            if (perfume == null)
            {
                return HttpNotFound();
            }

            var perfumeDetails = new PerfumeDetailsViewModel
            {
                PerfumeName = perfume.PerfumeName,
                Volume = _db.VolumeType.FirstOrDefault(s => s.PerfumeID == id)?.TypeName
            };

            return View(perfumeDetails);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Perfume model, string VolumeName)
        {
            if (ModelState.IsValid)
            {
                var newPerfume = new Perfume
                {
                    PerfumeName = model.PerfumeName,
                    PerfumeID = model.PerfumeID,
                    TypeID = model.TypeID,
                };

                _db.Perfume.Add(newPerfume);
                _db.SaveChanges();

                if (!string.IsNullOrEmpty(VolumeName))
                {
                    var Volume = new VolumeType
                    {
                        TypeName = VolumeName,
                        PerfumeID = newPerfume.PerfumeID // Use the new Plant's ID
                    };

                    _db.VolumeType.Add(Volume);
                    _db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var perfume = _db.Perfume.Find(id);

            if (perfume == null)
            {
                return HttpNotFound();
            }

            var Volume = _db.VolumeType.Where(s => s.PerfumeID == id);
            _db.VolumeType.RemoveRange(Volume);

            _db.Perfume.Remove(perfume);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var perfume = _db.Perfume.Find(id);

            if (perfume == null)
            {
                return HttpNotFound();
            }

            // Получаем связанную специализацию, если она существует
            var Volume = _db.VolumeType.FirstOrDefault(s => s.PerfumeID == id);
            ViewBag.SpecializationName = Volume?.TypeName;

            // Создаем модель для представления, которая объединяет данные растения и специализации
            var perfumeEditViewModel = new PerfumeEditViewModel
            {
                PerfumeID = perfume.PerfumeID,
                PerfumeName = perfume.PerfumeName,
                TypeID = (int)perfume.TypeID,
                VolumeName = ViewBag.SpecializationName
            };

            return View(perfumeEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PerfumeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingPerfume = _db.Perfume.Find(model.PerfumeID);

                if (existingPerfume == null)
                {
                    return HttpNotFound();
                }

                existingPerfume.PerfumeName = model.PerfumeName;
                existingPerfume.TypeID = model.TypeID;

                var existingSpecialization = _db.VolumeType.FirstOrDefault(s => s.PerfumeID == model.PerfumeID);

                if (existingSpecialization != null)
                {
                    existingSpecialization.TypeName = model.VolumeName;
                    _db.Entry(existingSpecialization).State = EntityState.Modified;
                }
                else
                {
                    var newSpecialization = new VolumeType
                    {
                        TypeName = model.VolumeName,
                        PerfumeID = model.PerfumeID
                    };

                    _db.VolumeType.Add(newSpecialization);
                }

                _db.Entry(existingPerfume).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }

}

