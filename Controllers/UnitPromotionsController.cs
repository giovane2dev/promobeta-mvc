using PagedList;
using Promobeta.Models;
using Promobeta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Promobeta.Controllers
{
    public class UnitPromotionsController : Controller
    {
        private ICompanyUnits ICompanyUnits;
        private IUnitPromotions IUnitPromotions;

        public UnitPromotionsController()
        {
            this.ICompanyUnits = new CompanyUnitsRepository(new PromobetaContext());
            this.IUnitPromotions = new UnitPromotionsRepository(new PromobetaContext());
        }

        // GET: UnitPromotions
        public ActionResult Index(int? id, int? page, string name)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            int CompanyUnitsId = (id ?? 0);

            var list = IUnitPromotions.UnitPromotions(CompanyUnitsId, name);

            return View(list.ToPagedList(pageNumber, pageSize));
        }

        // GET: UnitPromotions/Details/1
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnitPromotions/Create
        public ActionResult Create()
        {
            var list = ICompanyUnits.GetCompanyUnits(1);

            List<SelectListItem> units = new List<SelectListItem>();

            foreach (var l in list)
            {
                units.Add(new SelectListItem
                {
                    Text = l.Name,
                    Value = l.Id.ToString()
                });
            }

            ViewBag.CompanyUnitsId = units;

            return View();
        }

        // POST: UnitPromotions/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "CompanyUnitsId,StartDate,EndDate,Name,Description,Active")] UnitPromotions unitPromotions)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IUnitPromotions.Create(unitPromotions);                    
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitPromotions/Edit/1
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnitPromotions/Edit/1
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitPromotions/Delete/1
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnitPromotions/Delete/1
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
