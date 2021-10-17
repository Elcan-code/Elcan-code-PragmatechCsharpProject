using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Business.Services
{
    public interface IContactService
    {
        int Add(Contact entity);
        List<Contact> GetAll();
        int Update(Contact entity);
        int Delete(Guid id);
        int ExportXml(string name);
        int ExportJson(string name);
        int ExportCsv(string name);

    }
}
