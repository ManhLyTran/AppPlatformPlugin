﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppPlatform.LogService.BLL;

namespace UserManagerPlugin.Controllers
{
    public class LogManagerController : Controller
    {
        //
        // GET: /LogManager/

        private readonly ILogService _logService = new LogService();
        public ActionResult Index()
        {
           ViewData["log"]= _logService.LogGet();
            return View();
        }

    }
}
