using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileHelpers;

namespace cpSQLserverMVC.Controllers
{
    public class WebformConverterController : Controller
    {
        // GET: WebformConverter
        public ActionResult Index()
        {
            return View();
        }

        // GET: WebformConverter
        public ActionResult List()
        {
            return View();
        }

        // GET: WebformConverter/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebformConverter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebformConverter/Create
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

        // GET: WebformConverter/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebformConverter/Edit/5
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

        // GET: WebformConverter/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebformConverter/Delete/5
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


        // GET: WebformConverter/Delete/5
        public ActionResult Parse()
        {
            return View("Index");
        }

    }
}
