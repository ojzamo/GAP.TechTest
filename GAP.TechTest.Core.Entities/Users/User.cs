using GAP.TechTest.Core.Entities.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAP.TechTest.Core.Entities.Users
{
    [Table(nameof(User))]
    public class User : EntityFullAudited<Guid>
    {
        public const string AdminUserName = "admin";
        public const string DefaultPassword = "123qwe";

        
        [Required]
        [StringLength(256)]
        public virtual string EmailAddress { get; set; }
       
        [Required]
        [StringLength(128)]
        public virtual string Password { get; set; }
        
        [NotMapped]
        public virtual string FullName { get; }
        
        [Required]
        [StringLength(64)]
        public virtual string Surname { get; set; }
        
        [Required]
        [StringLength(64)]
        public virtual string Name { get; set; }

       
        [Required]
        [StringLength(256)]
        public virtual string UserName { get; set; }

        
        public virtual bool IsActive { get; set; }        
    }
}
