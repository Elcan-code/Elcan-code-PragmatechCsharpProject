using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOAPP_2_.DataAccess.Abstract;
using TODOAPP_2_.Entities.Concrete;

namespace TODOAPP_2_.DataAccess.Concrete
{
    public class InMemoryUserDal : IUserDal
    {
        private static readonly List<UserEntity> _userEntities;

            
        static InMemoryUserDal()
        {
            _userEntities = new List<UserEntity>
            {
                new UserEntity{Id=Guid.NewGuid(),UserName="User",Password="12345"}
            };
        }


        public void Add(UserEntity data)
        {
            _userEntities.Add(data);
        }

        public List<UserEntity> GetAll()
        {
            return _userEntities;
        }

        public UserEntity GetUser(string username, string password)
        { var user = _userEntities.SingleOrDefault(i => i.UserName == username && i.Password == password);
            return user;
        }
    }
}
