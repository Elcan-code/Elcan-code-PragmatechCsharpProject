using System.Collections.Generic;
using TODOAPP_2_.Entities.Concrete;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_.Business.Abstract
{
    interface ITodoService
    {
        int Count();
        int Add(TodoEntity data);
        List<TodoEntity> GettAll();
        List<TodoEntity> GettAll(Status status);
    }
}
