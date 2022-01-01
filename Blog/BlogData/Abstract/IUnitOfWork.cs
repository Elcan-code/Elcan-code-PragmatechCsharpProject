using System;
using System.Threading.Tasks;

namespace BlogData.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        public IUserRepository Users { get; }
        public IRoleRepository Roles { get; }
        public IPostRepository Posts { get; }
        public ICommentRepository Comments { get; }
        public ICategoryRepository Categories { get; }
        Task<int> SaveChangesAsync();
    }
}
