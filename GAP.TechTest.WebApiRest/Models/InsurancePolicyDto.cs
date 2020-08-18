using GAP.TechTest.Core.Entities.InsurancePolicies.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.TechTest.Core.Entities.InsurancePolicies
{
    
    public class InsurancePolicyDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        [Required]
        public string Description { get; set; }

        [Required]
        public int Period { get; set; }

        [Required]
        public double Price { get; set; }

        public CoverageDto CoverageType { get; set; }

        public Risk RiskType { get; set; }
    }
}
