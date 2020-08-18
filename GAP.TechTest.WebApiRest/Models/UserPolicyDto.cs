
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GAP.TechTest.Core.Entities.InsurancePolicies
{    
    public class UserPolicyDto
    {
        public Guid UserId { get; set; }
        public Guid InsurancePolicyId { get; set; }        


    }
}
