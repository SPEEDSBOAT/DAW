using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIDAW.Controllers;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ViewDepartmentController : Controller
    {
        // GET: ViewDepartment
        public ActionResult Index()
        {
            ApiDepartmentController db = new ApiDepartmentController();
            return View(db.GetAllDepartment());
        }
    }
}