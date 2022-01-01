using System.Threading.Tasks;
using BlogData.Abstract;
using BlogEntities.Concrete;
using BlogShared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogData.Concrete.EntityFramework.Repositories
{
    public class CategoryRepository : EfRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}