using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.TechTest.Web.MVC.Models
{
    public class IndexModel
    {
        public IEnumerable<InsurancePolicyModel> InsurancePolicyList { get; set; }
    }
}
