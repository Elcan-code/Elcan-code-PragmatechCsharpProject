using TODOAPP_2_.Business.Abstract;
using TODOAPP_2_.DataAccess.Concrete;
using TODOAPP_2_.Entities.Concrete;

namespace TODOAPP_2_.Business.Concrete
{
    class UserService : IUserService 
    { 
         private readonly InMemoryUserDal _userDal;

        public UserService(InMemoryUserDal userDal)
    {
        _userDal = userDal;
    }
    
        public UserEntity GetUser(string username, string password)
        {
            return _userDal.GetUser(username, password);
        }
    }
}
