using BlogData.Abstract;
using BlogEntities.Concrete;
using BlogShared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogData.Concrete.EntityFramework.Repositories
{
    public class CommentRepository : EfRepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {
        }
    }
}