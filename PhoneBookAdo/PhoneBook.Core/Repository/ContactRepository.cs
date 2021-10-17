using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PhoneBook.Core.Context;
using PhoneBook.Entities;
using System.Data;
namespace PhoneBook.Core.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly PhoneBookAdoDbContext _context;
        public ContactRepository()
        {
            _context = new PhoneBookAdoDbContext();
        }


        private SqlDataReader GetAllData()
        {
            _context.Command = new SqlCommand("Select * from Contact",_context.Connection);
            _context.SetConnection();
            return _context.Command.ExecuteReader();
        }
        public int Add(Contact entity)
        {
            try
            {
                _context.Command = new SqlCommand("insert into Contact values(@Id,@Name,@Surname,@Address,@Number1,@Number2,@Number3,@Email,@WebSite,@Description)",_context.Connection);
                _context.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value=entity.Id;
                _context.Command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = entity.Name;
                _context.Command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = entity.Surname;
                _context.Command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = entity.Address;
                _context.Command.Parameters.Add("@Number1", SqlDbType.NVarChar).Value = entity.Number1;
                _context.Command.Parameters.Add("@Number2", SqlDbType.NVarChar).Value = entity.Number2;
                _context.Command.Parameters.Add("@Number3", SqlDbType.NVarChar).Value = entity.Number3;
                _context.Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = entity.Email;
                _context.Command.Parameters.Add("@WebSite", SqlDbType.NVarChar).Value = entity.Website;
                _context.Command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = entity.Description;
                _context.SetConnection();
               return _context.ReturnValues = _context.Command.ExecuteNonQuery();
           
            
            }
            catch
            {
                
               
               
            }
            finally
            {
                GetAll();
                _context.SetConnection();
            }
            return _context.ReturnValues;
        }

        public int Delete(Guid Id)
        {
            try
            {
                _context.Command = new SqlCommand("delete Contact where Id=@Id", _context.Connection);
                _context.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = Id;
                _context.SetConnection();
                return _context.ReturnValues =(int) _context.Command.ExecuteNonQuery();
            }
            catch
            {
               
            }
            finally
            {
                GetAll();
                _context.SetConnection();

            }

            return _context.ReturnValues;
          
        }

        public List<Contact> GetAll()
        {
            List<Contact> entities = new List<Contact>();
            try
            {
                SqlDataReader reader = GetAllData();
                while (reader.Read())
                {
                    entities.Add(new Contact
                    {
                        Id = reader.GetGuid(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Address = reader.GetString(3),
                        Number1 =  reader.GetString(4),
                        Number2 =  reader.GetString(5),
                        Number3 =  reader.GetString(6),
                        Email =  reader.GetString(7),
                        Website =  reader.GetString(8),
                        Description =  reader.GetString(9),

                    }) ; 
                }

            }
            catch
            {

            }
            finally
            {
                _context.SetConnection();
            }
            return entities;
        }

        public int Update(Contact entity)
        {
            try
            {
                _context.Command = new SqlCommand("update Contact set [Name]=@Name,Surname=@Surname,Adress=@Address,Number1=@Number1,Number2=@Number2,Number3=@Number3,Email=@Email,Website=@Website,Description=@Description where Id=@Id",_context.Connection);
                _context.Command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = entity.Id;
                _context.Command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = entity.Name;
                _context.Command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = entity.Surname;
                _context.Command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = entity.Address;
                _context.Command.Parameters.Add("@Number1", SqlDbType.NVarChar).Value = entity.Number1;
                _context.Command.Parameters.Add("@Number2", SqlDbType.NVarChar).Value = entity.Number2;
                _context.Command.Parameters.Add("@Number3", SqlDbType.NVarChar).Value = entity.Number3;
                _context.Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = entity.Email;
                _context.Command.Parameters.Add("@WebSite", SqlDbType.NVarChar).Value = entity.Website;
                _context.Command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = entity.Description;
                _context.SetConnection();
                return _context.ReturnValues = _context.Command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                GetAll();
                _context.SetConnection();
            }
            return _context.ReturnValues;
        }
    }
}