using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Intermediate
{
    internal class DbCommand
    {
        private DbConnection _connection;
        private string _command;
        public DbCommand(DbConnection connection, string command)
        {
            if (connection == null || string.IsNullOrEmpty(command))
                throw new ArgumentException("Either the connection or the command is invalid");
            _connection = connection;
            _command = command;
        }
        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Executing the command: {0}", _command);
            _connection.Close();
        }
    }
}
