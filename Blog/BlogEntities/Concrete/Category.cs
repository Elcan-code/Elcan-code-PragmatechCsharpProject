using BlogShared.Entities;
using System.Collections.Generic;

namespace BlogEntities.Concrete
{
    public class Category : EntityBase, IEntity
        {
            public string Name { get; set; }
            public string Description { get; set; }

            // relations
            public ICollection<Post> Posts { get; set; }
        }
    }

