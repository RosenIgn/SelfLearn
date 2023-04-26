using MySql.Data.MySqlClient;

namespace Self_Learn
{
    class DBConnection
    {
        /* Променливи */

        public static MySqlConnection conn = null;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        /* Променливи */
        public void Connection() /* Функция за връзката на базата от данни към програмата */
        {
            server = "localhost";
            database = "localhost";
            uid = "localhost";
            password = "localhost";
            port = "port";

            string connString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};SSL Mode=None";

            conn = new MySqlConnection(connString);
        }
    }
}
