using System;
using TODOAPP_2_.Entities.Abstract;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_.Entities.Concrete
{
    public  class TodoEntity:BaseEntity<Guid>
   {
        public  string Title { get; set; }
        public string Shortdescription { get; set; }
        public  string Description { get; set; }
        public  int ImportanceLevel { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
