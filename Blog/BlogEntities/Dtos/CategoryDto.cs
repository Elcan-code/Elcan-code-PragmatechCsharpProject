using BlogEntities.Concrete;
using BlogShared.Entities.Abstract;
using System;
using System.Collections.Generic;


namespace BlogEntities.Dtos
{
    public class CategoryDto : GetBaseDto
    {
        public Category Entity { get; set; }
    }

    public class CategoryListDto : GetBaseDto
    {
        public IList<Category> Entities { get; set; }
    }
}
