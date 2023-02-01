using Promobeta.Models;
using Promobeta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Promobeta.Controllers
{
    public class CompanyController : Controller
    {
        private ICompany ICompany;

        public CompanyController()
        {
            this.ICompany = new CompanyRepository(new PromobetaContext());
        }

        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        // GET: Company/Details/1
        public ActionResult Details()
        {
            var details = ICompany.GetCompanyById(1);

            return View(details);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
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

        // GET: Company/Edit/1
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company/Edit/1
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

        // GET: Company/Delete/1
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company/Delete/1
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
