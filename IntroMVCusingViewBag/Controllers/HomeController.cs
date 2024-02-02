using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroMVCusingViewBag.Models;

namespace IntroMVCusingViewBag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Education()
        {
            List<Education> list = new List<Education>() {
        new Education() {
                Degree = "SSC",
                    Year = 2014,
                    Institution = "Model Academy, Mirpur"
            },
            new Education() {
                Degree = "HSC",
                    Year = 2016,
                    Institution = "Dhaka City College"
            },
            new Education() {
                Degree = "B.Sc. in Computer Science",
                    Year = 2024,
                    Institution = "AIUB"
            }
    };

            ViewBag.Message = "Education Information";
            ViewBag.model = list;
            return View();
        }

        public ActionResult Project()
        {
            List<Project> list = new List<Project>() {
        new Project() {
                CourseName = "OOP-1",
                    ProjectName = "E-Commerce Website"
            },
            new Project() {
                CourseName = "OOP-2",
                    ProjectName = "Hospital Management System"
            },
            new Project() {
                 CourseName = "Web Technology",
                    ProjectName = "Second Hand Book Platform"
            }
    };

            ViewBag.Message = "Project Information";
            ViewBag.model = list;
            return View();
        }
        public ActionResult Personal()
        {
            List<Personal> list = new List<Personal>() {
        new Personal() {
                Name = "Thanvir Ahmed",
                    ID = "20-43720-2",
                    Email = "thanvirahmed.aiubcse@gmail.com"
            }
    };

            ViewBag.Message = "Personal Information";
            ViewBag.model = list;
            return View();
        }

        public ActionResult Reference()
        {
            ViewBag.Title = "My Reference.";

            ViewBag.Message = "TANVIR AHMED, Lecturer , Computer Science, AIUB";


            return View();
        }
    }
}