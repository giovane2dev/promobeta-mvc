using Promobeta.Models;
using Promobeta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList; // Install-Package PagedList.Mvc


namespace Promobeta.Controllers
{
    public class CompanyUnitsController : Controller
    {
        private IState IState;
        private ICity ICity;
        private ICompanyUnits ICompanyUnits;

        public CompanyUnitsController()
        {
            this.IState = new StateRepository(new PromobetaContext());
            this.ICity = new CityRepository(new PromobetaContext());
            this.ICompanyUnits = new CompanyUnitsRepository(new PromobetaContext());            
        }

        // GET: Unit
        public ActionResult Index(int? page, string name)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var list = ICompanyUnits.GetCompanyUnits(1, name);

            return View(list.ToPagedList(pageNumber, pageSize));
        }

        // GET: Unit/Details/1
        public ActionResult Details()
        {
            return View();
        }

        // GET: Unit/Create
        public ActionResult Create()
        {
            var list = IState.GetStates();

            List<SelectListItem> states = new List<SelectListItem>();

            // add default item
            states.Add(new SelectListItem
            {
                Text = "Selecione",
                Value = ""
            });

            foreach (var l in list)
            {
                states.Add(new SelectListItem
                {
                    Text = l.Name,
                    Value = l.Id.ToString()
                });
            }

            ViewBag.StateId = states;

            return View();
        }

        // POST: Unit/Cities
        [HttpPost]
        public ActionResult Cities(int StateId)
        {
            var list = ICity.GetCitiesByStateId(StateId);

            return Json(new { list });
        }

        // POST: Unit/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "")] CompanyUnits companyUnits)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ICompanyUnits.Create(companyUnits);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Unit/Edit/1
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Unit/Edit/1
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

        // GET: Unit/Delete/1
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Unit/Delete/1
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
