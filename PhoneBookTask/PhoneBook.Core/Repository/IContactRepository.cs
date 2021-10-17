using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Repository
{
    public interface IContactRepository
    {
        int Add(Contact entity);
        List<Contact> GetAll();
        int Update(Contact entity);
        int Delete(Guid Id);
    }

}
