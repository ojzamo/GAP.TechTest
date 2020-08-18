using System;
using System.ComponentModel.DataAnnotations;

namespace GAP.TechTest.Web.MVC.Models
{
    
    public class InsurancePolicyModel
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

        public CoverageModel CoverageType { get; set; }

        public string RiskType { get; set; }
    }
}
