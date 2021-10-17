using System.Linq;
using PhoneBook.Core.Context;
using PhoneBook.Entities;
using System.Data.SqlClient;
namespace PhoneBook.Core.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PhoneBookAdoDbContext _context;
        public UserRepository()
        {
            _context = new PhoneBookAdoDbContext();
        }
    

        public int Login(User entity)
        {
            try
            {
                _context.Command = new SqlCommand("Select Count(*) from [User] where [Username]=@Username and Password=@Password", _context.Connection);
                _context.Command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar).Value = entity.Username;
                _context.Command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar).Value = entity.Password;
                _context.SetConnection();
                _context.ReturnValues = (int)_context.Command.ExecuteScalar();
            }
            catch
            {
               
              
            }
            finally
            {
                _context.SetConnection();
            }
            return _context.ReturnValues;
        }

    
    }
} 