using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SP749415_MIS4200.DAL;
using SP749415_MIS4200.Models;

namespace SP749415_MIS4200.Controllers
{
    public class AppointmentsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Appointments
        public ActionResult Index()
        {
            var appointments = db.Appointments.Include(a => a.Pets).Include(a => a.Vet);
            return View(appointments.ToList());
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointments appointments = db.Appointments.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            return View(appointments);
        }

        // GET: Appointments/Create
        public ActionResult Create()
        {
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName");
            ViewBag.vetID = new SelectList(db.Vets, "vetId", "vetFirstName");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentID,description,cost,appointmentDateTime,petID,vetID")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Appointments.Add(appointments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", appointments.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetId", "vetFirstName", appointments.vetID);
            return View(appointments);
        }

        // GET: Appointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointments appointments = db.Appointments.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", appointments.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetId", "vetFirstName", appointments.vetID);
            return View(appointments);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentID,description,cost,appointmentDateTime,petID,vetID")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", appointments.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetId", "vetFirstName", appointments.vetID);
            return View(appointments);
        }

        // GET: Appointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointments appointments = db.Appointments.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            return View(appointments);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appointments appointments = db.Appointments.Find(id);
            db.Appointments.Remove(appointments);
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
