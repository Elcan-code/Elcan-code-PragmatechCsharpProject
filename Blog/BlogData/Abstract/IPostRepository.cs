using BlogEntities.Concrete;
using BlogShared.Data.Abstract;

namespace BlogData.Abstract
{
    public interface IPostRepository : IEntityRepository<Post>
    {
    }
}