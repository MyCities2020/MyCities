using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyCities.Controllers
{
    public class BatimentController : Controller
    {
        // GET: Batiment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Batiment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Batiment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Batiment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Batiment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Batiment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Batiment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Batiment/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}