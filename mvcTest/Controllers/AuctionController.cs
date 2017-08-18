﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcTest.Models;

namespace mvcTest.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {

            List<Auction> lst = new List<Auction>();

            var auction = new Auction
            {
                Id = 1,
                Title = "Brand new Widget 2.0",
                Description = "This is a brand new version 2.0 widget",
                StartPrice = 1.00m,
                CurrentPrice = 13.4m,
                StartTime = DateTime.Parse("2017-07-11"),
                EndTime = DateTime.Parse("2018-07-11"),



            };

            lst.Add(auction);

            return View(lst);
        }


        /// <summary>
        /// 显示详细信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        // GET: Auction/Details/5
        public ActionResult Details(int id=1)
        {
            var auction = new Auction
            {
                Id = id,
                Title = "Brand new Widget 2.0",
                Description = "This is a brand new version 2.0 widget",
                StartPrice = 1.00m,
                CurrentPrice = 13.4m,
                StartTime = DateTime.Parse("2017-07-11"),
                EndTime = DateTime.Parse("2018-07-11"),



            };



            return View(auction);
        }

        // GET: Auction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auction/Create
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

        // GET: Auction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Auction/Edit/5
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

        // GET: Auction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Auction/Delete/5
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
