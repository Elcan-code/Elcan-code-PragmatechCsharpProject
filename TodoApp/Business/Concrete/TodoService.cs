using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOAPP_2_.Business.Abstract;
using TODOAPP_2_.DataAccess.Concrete;
using TODOAPP_2_.Entities.Concrete;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_.Business.Concrete
{
    class TodoService : ITodoService
    {
        private readonly InMemoryTodoDal _todoDal;

        public TodoService(InMemoryTodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public int Add(TodoEntity data)
        {
            return _todoDal.Add(data);
        }

        public int Count()
        {
           return _todoDal.Count();
        }

        public List<TodoEntity> GettAll()
        {
            return _todoDal.GetAll();
        }

        public List<TodoEntity> GettAll(Status status)
        {
            return _todoDal.GetAll(status);
        }
    }
}
