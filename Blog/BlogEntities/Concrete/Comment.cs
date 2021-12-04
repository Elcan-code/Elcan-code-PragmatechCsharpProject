using BlogShared.Entities;

namespace BlogEntities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; }

        // relations
        public Post Post { get; set; }
    }
    }

