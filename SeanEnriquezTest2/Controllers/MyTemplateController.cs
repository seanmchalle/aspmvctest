using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeanEnriquezTest2.Controllers
{
    public class MyTemplateController : Controller
    {
        //
        // GET: /MyTemplate/

        public ActionResult Index()
        {
            //DATA FOR HEADER
            ViewBag.HeaderStudent = new string[4];
            ViewBag.HeaderStudent[0] = "Student #"; ViewBag.HeaderStudent[1] = "Name";
            ViewBag.HeaderStudent[2] = "Address"; ViewBag.HeaderStudent[3] = "Contact";

            ViewBag.HeaderSubject = new string[2];
            ViewBag.HeaderSubject[0] = "Student #"; ViewBag.HeaderSubject[1] = "Subject";

            //DATA FOR STUDENT TABLE
            ViewBag.Student = new string[3, 4];
            ViewBag.Student[0, 0] = "00001";
            ViewBag.Student[0, 1] = "Student A";  
            ViewBag.Student[0, 2] = "Address A";
            ViewBag.Student[0, 3] = "09111111111";

            ViewBag.Student[1, 0] = "00002";
            ViewBag.Student[1, 1] = "Student B";
            ViewBag.Student[1, 2] = "Address B";
            ViewBag.Student[1, 3] = "0922222222";

            ViewBag.Student[2, 0] = "00003";
            ViewBag.Student[2, 1] = "Student C";
            ViewBag.Student[2, 2] = "Address C";
            ViewBag.Student[2, 3] = "0933333333";

            //DATA FOR SUBJECT TABLE
            ViewBag.Subjects = new string[6,2];
            ViewBag.Subjects[0, 0] = "00001";
            ViewBag.Subjects[0, 1] = "CS101";
            ViewBag.Subjects[1, 0] = "00001";
            ViewBag.Subjects[1, 1] = "IT110";

            ViewBag.Subjects[2, 0] = "00002";
            ViewBag.Subjects[2, 1] = "CS102";
            ViewBag.Subjects[3, 0] = "00002";
            ViewBag.Subjects[3, 1] = "IT220";

            ViewBag.Subjects[4, 0] = "00003";
            ViewBag.Subjects[4, 1] = "CS302";
            ViewBag.Subjects[5, 0] = "00003";
            ViewBag.Subjects[5, 1] = "IT220";

            return View();
        }
        
        public ActionResult AboutUs()
        {
            ViewBag.Name = "Sean McHalle B. Enriquez";
            return View("AboutUs");
        }

        public ActionResult News()
        {
            return View("News");
        }

    }
}
