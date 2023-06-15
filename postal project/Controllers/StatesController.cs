﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using postal_project.Data;
using postal_project.Models;

namespace postal_project.Controllers
{
    public class StatesController : Controller
    {
        private postal_projectContext db = new postal_projectContext();

        // GET: States
        public ActionResult Index()
        {
            return View(db.States.ToList());
        }

        // GET: States/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            States states = db.States.Find(id);
            if (states == null)
            {
                return HttpNotFound();
            }
            return View(states);
        }

        // GET: States/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: States/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StateID,Name,CountryID,isactive")] States states)
        {
            if (ModelState.IsValid)
            {
                db.States.Add(states);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(states);
        }

        // GET: States/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            States states = db.States.Find(id);
            if (states == null)
            {
                return HttpNotFound();
            }
            return View(states);
        }

        // POST: States/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StateID,Name,CountryID,isactive")] States states)
        {
            if (ModelState.IsValid)
            {
                db.Entry(states).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(states);
        }

        // GET: States/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            States states = db.States.Find(id);
            if (states == null)
            {
                return HttpNotFound();
            }
            return View(states);
        }

        // POST: States/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            States states = db.States.Find(id);
            db.States.Remove(states);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
