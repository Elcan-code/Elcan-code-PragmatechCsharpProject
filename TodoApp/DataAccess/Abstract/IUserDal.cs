using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOAPP_2_.Entities.Concrete;

namespace TODOAPP_2_.DataAccess.Abstract
{
    public interface IUserDal
    {
        UserEntity GetUser(string username, string password);
        List<UserEntity> GetAll();
        void Add(UserEntity data);
    }
}
