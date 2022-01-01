using BlogData.Abstract;
using BlogEntities.Concrete;
using BlogShared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogData.Concrete.EntityFramework.Repositories
{
    public class RoleRepository : EfRepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}