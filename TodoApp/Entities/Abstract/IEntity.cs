using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAPP_2_.Entities.Abstract
{
   public interface IEntity<T>
    {
        T Id { get; set; }
   

    }
    public abstract class BaseEntity
    {

    }
    public abstract class BaseEntity<T> : BaseEntity, IEntity<T>
    {
        public T Id { get; set; }
    }
}
