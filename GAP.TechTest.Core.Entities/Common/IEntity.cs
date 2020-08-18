using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.TechTest.Core.Entities.Common
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }        

    }
}
