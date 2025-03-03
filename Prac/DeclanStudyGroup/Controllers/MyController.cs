using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeclanStudyGroup.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult StudyGroup()
        {
            List<Models.MyClass> StudyGroup  = new List<Models.MyClass>();

            StudyGroup.Add(new Models.MyClass { StudentNum = "u23657597", FirstName = "Declan", LastName = "Van Wyk", Email = "u23657597@tuks.co.za" });
            StudyGroup.Add(new Models.MyClass { StudentNum = "u24106238", FirstName = "Mpho", LastName = "Machilo", Email = "u24106238@tuks.co.za" });
            StudyGroup.Add(new Models.MyClass { StudentNum = "u24336901", FirstName = "Leporta", LastName = "Ramaema", Email = "u24336901@tuks.co.za" });
            StudyGroup.Add(new Models.MyClass { StudentNum = "u23769138", FirstName = "Tashvir", LastName = "Sewkumar", Email = "u23769138@tuks.co.za" });
            StudyGroup.Add(new Models.MyClass { StudentNum = "u23115494", FirstName = "Andrea", LastName = "Augustine", Email = "u23115494@tuks.co.za" });

            return View(StudyGroup);
        }
    }
}