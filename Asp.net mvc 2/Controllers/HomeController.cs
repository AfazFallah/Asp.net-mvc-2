using Asp.net_mvc_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.net_mvc_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Students> studentList = new List<Students>() 
            {
                new Students(1,"afaz" , "fallah" , 19),
                new Students(2 , "yasin" , "Abedini" , 18),
                new Students(3 , "reza" , "nekoohi" , 20),
                new Students(4 , "mehdi" , "kalantari" , 18)
            };
            return View(studentList);
        }
        public ActionResult Login()
        {
            Students students = new Students(1, "afaz", "fallah", 19);
            return View(students);
        }
        public ActionResult DeleteUser()
        {
            return View();
        }
        public ActionResult UpgradeUser()
        {
            return View();
        }

    }
}