using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDAW.Models;
using System.Data.Entity;

namespace APIDAW.Controllers
{
    public class ApiDepartmentController : Controller
    {
        public DAWEntities db = new DAWEntities();
        public IEnumerable<Department> GetAllDepartment()
        {
            var Get = db.Department.ToList();
            return Get;
        }
        public void Add(Department model)
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
        public void Update(Department model)
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
        public void Delete(Department model)
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