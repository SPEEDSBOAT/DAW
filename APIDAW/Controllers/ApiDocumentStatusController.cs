using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDAW.Models;

namespace APIDAW.Controllers
{
    public class ApiDocumentStatusController : Controller
    {
        // GET: ApiDocumentStatus
        public DAWEntities db = new DAWEntities();

        public void Add(DocumentStatus model)
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
        public void Update(DocumentStatus model)
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

        public void Delete(DocumentStatus model)
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

        public IEnumerable<DocumentStatus> GetAllDocumentStatus()
        {
            var Get = db.DocumentStatus.ToList();
            return Get;
        }
    }
}