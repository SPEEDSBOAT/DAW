using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIDAW.Models;
using System.Data.Entity;

namespace APIDAW.Controllers
{
    public class ApiViewDocTypeWorkGroupController : Controller
    {
        // GET: ApiViewDocTypeWorkGroup
        public DAWEntities db = new DAWEntities();
        public IEnumerable<ViewDocTypeWorkGroup> GetAllDocumentType()
        {
            var Get = db.ViewDocTypeWorkGroup.ToList();
            return Get;
        }
        public IEnumerable<WorkflowGroup> GetAllWorkGroup()
        {
            var Get = db.WorkflowGroup.ToList();
            return Get;
        }
        public void Add(DocumentType model)
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
        public void Update(DocumentType model)
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
        public void Delete(DocumentType model)
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