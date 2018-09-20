using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDAW.Models;

namespace WebApplication1.Models
{
    public class ApiAddVisitorModel
    {
        public User User { get; set; } = new User();
        public Department Department { get; set; } = new Department();
        public Actions Actions { get; set; } = new Actions();
        //public List<Attacthment> Attacthment { get; set; } = new List<Attacthment>();

        public String Status { get; set; }
    }

}