using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BlogEntities.Concrete;

namespace BlogEntities.Dtos
{

    public class PostAddDto
    {
     
        public int UserId { get; set; }

     
        public int CategoryId { get; set; }

     
        public string Title { get; set; }

      
        public string Content { get; set; }

       
        public string Thumbnail { get; set; }

        
        public DateTime Date { get; set; }

       
        public string SeoAuthor { get; set; }

       
        public string SeoDescription { get; set; }

        public string SeoTags { get; set; }

     
        public string Note { get; set; }

       
        public bool IsActive { get; set; }

    }
}

