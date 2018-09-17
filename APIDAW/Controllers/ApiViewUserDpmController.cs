using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDAW.Models;
using System.Data.Entity;

namespace APIDAW.Controllers
{
    public class ApiViewUserDpmController : Controller
    {
        public DAWEntities db = new DAWEntities();
        // GET: ApiViewUserDpm
        public ActionResult Index()
        {
            return View();
        }
        public IEnumerable<ViewUserDpm> GetAllViewUserDpm()
        {
            var Get = db.ViewUserDpm.ToList();
            return Get;
        }
        public IEnumerable<Department> GetAllDepartment()
        {
            var Get = db.Department.ToList();
            return Get;
        }
        public void Add(User model)
        {
            int result = 0;

            try
            {
                db.Entry(model).State = EntityState.Added;
                result = db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(User model)
        {
            int result = 0;

            try
            {
                db.Entry(model).State = EntityState.Modified;
                result = db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(User model)
        {
            int result = 0;

            try
            {
                db.Entry(model).State = EntityState.Deleted;
                result = db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}