using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Context
{
   public class PhoneBookAdoDbContext
    {
        public PhoneBookAdoDbContext()
        {
            _Connection = new SqlConnection("Data Source=.;Initial Catalog=PhoneBook;Integrated Security=True");
        }
        private SqlConnection _Connection;

        public SqlConnection Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }
        private SqlCommand _Command;

        public SqlCommand Command
        {
            get { return _Command; }
            set { _Command = value; }
        }

        private SqlDataReader _DataReader;

        public SqlDataReader DataReader
        {
            get { 
                return _DataReader; }
            set {
                _DataReader = value; }
        }
        private int _ReturnValues;

        public int ReturnValues
        {
            get { return _ReturnValues; }
            set { _ReturnValues = value; }
        }
        public void SetConnection()
        {
            if (_Connection.State == System.Data.ConnectionState.Closed)
            {
                _Connection.Open();
            }
            else
            {
                _Connection.Close();
            }
        }
    }
}
