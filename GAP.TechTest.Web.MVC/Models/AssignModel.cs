using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.TechTest.Web.MVC.Models
{
    public class AssignModel
    {
        public Guid UserId { get; set; }
        public Guid InsurancePolicyId { get; set; }

        public string Name { get; set; }
    }
}
