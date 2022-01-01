using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntities.Dtos
{
  public  class PostUpdateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }

        [DisplayName("Is active ?")]
        [Required(ErrorMessage = "{0} is required.")]
        public bool IsActive { get; set; }

        [DisplayName("Is deleted ?")]
        [Required(ErrorMessage = "{0} is required.")]
        public bool IsDeleted { get; set; }
    }
}
