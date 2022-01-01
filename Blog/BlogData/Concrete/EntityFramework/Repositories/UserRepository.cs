using BlogData.Abstract;
using BlogEntities.Concrete;
using BlogShared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogData.Concrete.EntityFramework.Repositories
{
    public class UserRepository : EfRepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}