using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOAPP_2_.Entities.Abstract;

namespace TODOAPP_2_.Entities.Concrete
{
    public  class UserEntity:BaseEntity<Guid>
  {
        public  string UserName { get; set; }
        public  string Password { get; set; }
    }  
}
