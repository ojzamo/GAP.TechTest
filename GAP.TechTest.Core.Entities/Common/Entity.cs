using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GAP.TechTest.Core.Entities.Common
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>, IObjectState
    {        
        public virtual TPrimaryKey Id { get; set; }      
    
        [NotMapped]
        public ObjectState ObjectState { get; set; }

    }
}
