using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_OMG
{
     class DB
    {
        MySqlConnection connection = new MySqlConnection("server=ftp.a0742318.xsph.ru;username=a0742318;password=hihenizive;database=a0742318_authorization_users");

        //открывает соединение с бд
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        //закрыввает подключение к бд
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //возвращает соединение с бд
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
