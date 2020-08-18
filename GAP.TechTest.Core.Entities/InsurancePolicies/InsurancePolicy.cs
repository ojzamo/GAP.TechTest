using GAP.TechTest.Core.Entities.Common;
using GAP.TechTest.Core.Entities.InsurancePolicies.Enum;
using GAP.TechTest.Core.Entities.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.TechTest.Core.Entities.InsurancePolicies
{
    [Table(nameof(InsurancePolicy))]
    public class InsurancePolicy : EntityFullAudited<Guid>
    {

        #region Constants

        /// <summary>
        /// Max string length allowed at exact Name
        /// </summary>
        public const int MaxNameLength = 200;

        /// <summary>
        /// Max string length allowed at Description
        /// </summary>
        public const int MaxDescriptionLength = 400;

        #endregion

        
        [StringLength(MaxNameLength)]
        [Required]
        public string Name { get; set; }

        [StringLength(MaxDescriptionLength)]
        [Required]
        public string Description { get; set; }

        [Required]
        public int Period { get; set; }

        [Required]
        public double Price { get; set; }

        public Coverage CoverageType { get; set; }

        public Risk RiskType { get; set; }
    }
}
