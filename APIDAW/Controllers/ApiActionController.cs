using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDAW.Models;
using System.Data.Entity;

namespace APIDAW.Controllers
{
    public class ApiActionController : Controller
    {
        // GET: ApiApprovalStatus
        public DAWEntities db = new DAWEntities();
        public IEnumerable<Actions> GetAllAction()
        {
            var Get = db.Actions.ToList();
            return Get;
        }

        public void Add(Actions model)
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
        public void Update(Actions model)
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
        public void Delete(Actions model)
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