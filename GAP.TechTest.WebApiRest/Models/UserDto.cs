
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GAP.TechTest.Core.Entities.InsurancePolicies
{    
    public class UserDto
    {
        public Guid Id { get; set; }

        [Required]        
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
        

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]        
        public string UserName { get; set; }
    }
}
