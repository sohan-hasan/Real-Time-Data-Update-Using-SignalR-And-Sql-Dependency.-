﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestSqlToSignalRCommunication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetMessages()
        {   
            Repository repo = new Repository();
            List<Employee> employees = repo.GetAllMessages();
            return Json(employees, JsonRequestBehavior.AllowGet); ;
        }
    }
}