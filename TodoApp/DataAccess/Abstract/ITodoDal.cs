using System.Collections.Generic;
using TODOAPP_2_.Entities.Concrete;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_.DataAccess.Abstract
{
    public interface ITodoDal
    {
        int Count();
        int Add(TodoEntity data);
        List<TodoEntity> GetAll();
        List<TodoEntity> GetAll(Status status);

    }
}
