﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZTB.OA.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //主页查找
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}