using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDAW.Controllers;
using APIDAW.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        //GET:Document_status
        public ActionResult V_document_status()
        {
            ApiDocumentStatusController db = new ApiDocumentStatusController();
            return View(db.GetAllDocumentStatus());
        }
        public JsonResult Insert_document_status(DocumentStatus model)
        {
            ApiDocumentStatusController db = new ApiDocumentStatusController();
            db.Add(model);
            var get = db.GetAllDocumentStatus();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Edit_document_status(DocumentStatus model)
        {
            ApiDocumentStatusController db = new ApiDocumentStatusController();
            db.Update(model);
            var get = db.GetAllDocumentStatus();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete_document_status(DocumentStatus model)
        {
            ApiDocumentStatusController db = new ApiDocumentStatusController();
            db.Delete(model);
            var get = db.GetAllDocumentStatus();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }

        // GET: Department
        public ActionResult V_manage_department()
        {
            ApiDepartmentController db = new ApiDepartmentController();

            return View(db.GetAllDepartment());
        }
        public JsonResult Insert_department(Department model)
        {
            ApiDepartmentController db = new ApiDepartmentController();
            db.Add(model);
            var get = db.GetAllDepartment();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update_department(Department model)
        {
            ApiDepartmentController db = new ApiDepartmentController();
            db.Update(model);
            var get = db.GetAllDepartment();
            var allYear = get.ToList();
            var eiei = Json(allYear, JsonRequestBehavior.AllowGet);
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete_department(Department model)
        {
            ApiDepartmentController db = new ApiDepartmentController();
            db.Delete(model);
            var get = db.GetAllDepartment();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }

        //GET:Action
        public ActionResult V_action()
        {
            ApiActionController db = new ApiActionController();
            return View(db.GetAllAction());
        }
        public JsonResult Insert_action(Actions model)
        {
            ApiActionController db = new ApiActionController();
            db.Add(model);
            var get = db.GetAllAction();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update_action(Actions model)
        {
            ApiActionController db = new ApiActionController();
            db.Update(model);
            var get = db.GetAllAction();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete_action(Actions model)
        {
            ApiActionController db = new ApiActionController();
            db.Delete(model);
            var get = db.GetAllAction();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }

        //GET:Document_type
        public ActionResult V_document_type()
        {
            ApiDocumentTypeController db = new ApiDocumentTypeController();
            return View(db.GetAllDocumentType());
        }
        public JsonResult Insert_document_type(DocumentType model)
        {
            ApiDocumentTypeController db = new ApiDocumentTypeController();
            db.Add(model);
            var get = db.GetAllDocumentType();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update_document_type(DocumentType model)
        {
            ApiDocumentTypeController db = new ApiDocumentTypeController();
            db.Update(model);
            var get = db.GetAllDocumentType();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete_document_type(DocumentType model)
        {
            ApiDocumentTypeController db = new ApiDocumentTypeController();
            db.Delete(model);
            var get = db.GetAllDocumentType();
            var allYear = get.ToList();
            var eiei = Json(allYear, JsonRequestBehavior.AllowGet);
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }

        //GET:ViewUserDepartment
        public ActionResult V_manage_user()
        {
            ApiViewUserDpmController db = new ApiViewUserDpmController();
            ViewBag.Department = db.GetAllDepartment();
            return View(db.GetAllViewUserDpm());
        }
        public JsonResult Insert_user(User model)
        {
            ApiViewUserDpmController db = new ApiViewUserDpmController();
            db.Add(model);
            var get = db.GetAllViewUserDpm();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update_user(User model)
        {
            ApiViewUserDpmController db = new ApiViewUserDpmController();
            db.Update(model);
            var get = db.GetAllViewUserDpm();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete_user(User model)
        {
            ApiViewUserDpmController db = new ApiViewUserDpmController();
            db.Delete(model);
            var get = db.GetAllViewUserDpm();
            var allYear = get.ToList();
            return Json(allYear, JsonRequestBehavior.AllowGet);
        }
    }
}