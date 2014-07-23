﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UserInfoProject;

namespace UserInfo.Controllers
{
    public class UserInfoesController : Controller
    {
        private UserInfoEntities db = new UserInfoEntities();

        // GET: UserInfoes
        public ActionResult Index()
        {
            return View(db.UserInfoes.ToList());
        }

        // GET: UserInfoes/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    //UserInfo userInfo1 = db.UserInfoes.Find(id);
        //    if (userInfo1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userInfo1);
        //}

         //GET: UserInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserInfoModel ObjUserInf)
        {
            if (ModelState.IsValid)
            {
                db.UserInfoes.Add(ObjUserInf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ObjUserInf);
        }

        // GET: UserInfoes/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UserInfo userInfo = db.UserInfoes.Find(id);
        //    if (userInfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userInfo);
        //}

        // POST: UserInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "UserInfo_ID,FirstName,LastName,EmailAddress")] UserInfo userInfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(userInfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(userInfo);
        //}

        // GET: UserInfoes/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    UserInfo userInfo = db.UserInfoes.Find(id);
        //    if (userInfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userInfo);
        //}

        // POST: UserInfoes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    UserInfo userInfo = db.UserInfoes.Find(id);
        //    db.UserInfoes.Remove(userInfo);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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