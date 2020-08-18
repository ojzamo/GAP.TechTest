using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.TechTest.Core.Entities.Common
{
    public class EntityFullAudited<TPrimaryKey> : Entity<TPrimaryKey>
    {
        #region Audited fields

       public DateTime CreationTime { get; set; }
        
        public long? CreatorUserId { get; set; }

        
        public DateTime? LastModificationTime { get; set; }

        
        public long? LastModifierUserId { get; set; }

        
        public bool? IsDeleted { get; set; }

        
        public DateTime? DeletionTime { get; set; }        
        
        public long? DeleterUserId { get; set; }
        #endregion
    }
}
