using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalLibrary
{
   
    public abstract class Connection
    {
        public abstract bool OpenConnection();
        public abstract bool CloseConnection();
    }

    public class SQLConnection : Connection
    {
        public override bool CloseConnection()
        {
            return true; // SQL' e özel connection işlemleri
        }

        public override bool OpenConnection()
        {
            return true; // SQL' e özel connection işlemleri
        }
    }

    public class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            return true; // Oracle' e özel connection işlemleri
        }

        public override bool OpenConnection()
        {
            return true; // Oracle' e özel connection işlemleri
        }
    }

    public abstract class Command
    {
        public abstract string ExecuteCommand(string Query);
    }

    public class SQLCommand : Command
    {
        public override string ExecuteCommand(string Query)
        {
            // Gelen sorgunun çalıştırılması için
            // Gerekli operasyonel işlemler...
            return "";
        }
    }

    public class OracleCommand : Command
    {
        public override string ExecuteCommand(string Query)
        {
            // Gelen sorgunun çalıştırılması için
            // Gerekli operasyonel işlemler...
            return "";
        }
    }

    public interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }

    public class SQLDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new SQLCommand();
        }

        public Connection CreateConnection()
        {
            return new SQLConnection();
        }
    }

    public class OracleDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new OracleCommand();
        }

        public Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }

    public class DatabaseOperation
    {
        IDatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;

        public DatabaseOperation(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void RemoveById(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("DELETE ...");
            _connection.CloseConnection();
        }
    }
}
