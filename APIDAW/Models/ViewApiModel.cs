using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDAW.Models
{
    public class ApiAddVisitorModel
    {
        public User User { get; set; } = new User();
        public Department Department { get; set; } = new Department();
        public Actions Actions { get; set; } = new Actions();
        //public List<Attacthment> Attacthment { get; set; } = new List<Attacthment>();
        public DocumentType DocumentType { get; set; } = new DocumentType();
        public String Status { get; set; }
    }
}