﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpPlaylist.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            return View();
        }
    }
}