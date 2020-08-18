using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.TechTest.Web.MVC.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
