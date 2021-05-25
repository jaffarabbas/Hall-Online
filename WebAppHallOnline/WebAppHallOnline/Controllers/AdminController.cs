using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppHallOnline.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index(){
            return View();
        }
        public ActionResult map(){
            return View();
        }
        public ActionResult Newuser_List(){
            return View();
        }
        public ActionResult notifications(){
            return View();
        }
        public ActionResult Report(){
            return View();
        }
        public ActionResult tables(){
            return View();
        }
        public ActionResult user(){
            return View();
        }
        
    }
}