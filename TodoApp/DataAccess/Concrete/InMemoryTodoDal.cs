using System;
using System.Collections.Generic;
using System.Linq;
using TODOAPP_2_.DataAccess.Abstract;
using TODOAPP_2_.Entities.Concrete;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_.DataAccess.Concrete
{
    public class InMemoryTodoDal : ITodoDal
    {
        private static readonly List<TodoEntity> _todoEntities;


        static InMemoryTodoDal()
        {
            _todoEntities = new List<TodoEntity>();
         
        }


        public int Add(TodoEntity data)
        {
            _todoEntities.Add(data);
            return 1;
        }

    

        public int Count()
        {
            return _todoEntities.Count();
        }

        public List<TodoEntity> GetAll()
        {
            return _todoEntities;
        }

        public List<TodoEntity> GetAll(Status status)
        {
            return _todoEntities.Where(i => i.Status == status).ToList();
        }
    }
}
