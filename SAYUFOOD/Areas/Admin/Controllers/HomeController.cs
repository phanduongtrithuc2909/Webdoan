﻿using SAYUFOOD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAYUFOOD.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin, Employe")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}