using GAP.TechTest.Core.Entities.Common;
using GAP.TechTest.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GAP.TechTest.Core.Entities.InsurancePolicies
{
    [Table(nameof(Coverage))]
    public class Coverage : EntityFullAudited<Guid>
    {

        #region Constants

        /// <summary>
        /// Max string length allowed at exact Name
        /// </summary>
        public const int MaxNameLength = 200;
        

        #endregion


        [StringLength(MaxNameLength)]
        [Required]
        public string Name { get; set; }

        public float? Percent { get; set; }
    }
}
