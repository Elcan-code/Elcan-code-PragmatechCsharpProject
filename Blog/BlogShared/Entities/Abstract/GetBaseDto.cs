using BlogShared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogShared.Entities.Abstract
{
    public abstract class GetBaseDto
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
