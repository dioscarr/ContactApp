using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Contact.Data;
using ContactList.Models;

namespace ContactList.Controllers
{
    [Authorize(Users="CtoonzOfficial@gmail.com")]
    public class ContactTablesController : Controller
    {
        private UserInfoEntitiesCon db = new UserInfoEntitiesCon();
        
        

        // GET: ContactTables
        
        public ActionResult Index()
        {

            



            return View(db.ContactTables.ToList());
        }

        public ActionResult OrderByNameDes()
        {

            var Contacts = (from p in db.ContactTables
                    orderby p.FirstName descending
                    select  p).AsEnumerable();

            return View(Contacts);
        }

        public ActionResult OrderByNameAsc()
        {

            var Contacts = (from p in db.ContactTables
                            orderby p.FirstName ascending
                            select p).AsEnumerable();

            return View(Contacts);
        }

        // GET: ContactTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

         

                    

            ContactTable contactTable = db.ContactTables.Find(id);
            if (contactTable == null)
            {
                return HttpNotFound();
            }
            return View(contactTable);
        }

        // GET: ContactTables/Create
        public ActionResult Create()

        {
            List<State> ObjStateList = db.States.ToList();
            ViewBag.Mylist = ObjStateList;
            return View();
        }

        // POST: ContactTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserInfo_ID,FirstName,LastName,EmailAddress,State")] ContactTable contactTable)
        {
            if (ModelState.IsValid)
            {
                db.ContactTables.Add(contactTable);
                 db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactTable);
        }

        // GET: ContactTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactTable contactTable = db.ContactTables.Find(id);
            if (contactTable == null)
            {
                return HttpNotFound();
            }
            return View(contactTable);
        }

        // POST: ContactTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserInfo_ID,FirstName,LastName,EmailAddress,State")] ContactTable contactTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactTable);
        }

        // GET: ContactTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactTable contactTable = db.ContactTables.Find(id);
            if (contactTable == null)
            {
                return HttpNotFound();
            }
            return View(contactTable);
        }

        // POST: ContactTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactTable contactTable = db.ContactTables.Find(id);
            db.ContactTables.Remove(contactTable);
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
