using GAP.TechTest.Core.Entities.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.TechTest.Core.Entities.Users
{
    [Table(nameof(UserPolicy))]
    public class UserPolicy : EntityFullAudited<Guid>
    {
        
        [Required]
        public virtual Guid InsurancePolicyId { get; set; }

        [Required]
        public virtual Guid UserId { get; set; }
        public virtual bool IsActive { get; set; }        
    }
}
