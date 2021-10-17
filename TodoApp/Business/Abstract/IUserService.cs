using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOAPP_2_.Entities.Concrete;

namespace TODOAPP_2_.Business.Abstract
{
    interface IUserService
    {
        UserEntity GetUser(string username, string password);
    }
}
