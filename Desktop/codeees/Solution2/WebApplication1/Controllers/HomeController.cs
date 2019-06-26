using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL;
using BOL;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name,string Password,string returnUrl)
        {
            if (RepoManager.Validate(name, Password))
            {
                FormsAuthentication.SetAuthCookie("name", false);
                return Redirect(returnUrl ?? Url.Action("Display", "Home"));
            }
            else {
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int id,string name,string address,string salary,string password,string returnUrl)
        {

            if (RepoManager.Insert(id, name, address, salary, password))
            {
                return Redirect(returnUrl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Msg()
        {
            return View();
        }

        public ActionResult Display()
        {
            List<Employee> emp = RepoManager.getAllDetails();
            ViewData["emp"] = emp;

            return View();


            
        }

        public ActionResult Update()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Update(int id,string password,string returnUrl)
        {
            if(RepoManager.Update(id,password))
            {
                return Redirect(returnUrl ?? Url.Action("Msg", "Home"));
            }
            else
            { 
            return View();
            }

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
    }
}