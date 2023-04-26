using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Self_Learn
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginRegister());

        } /* Начало на програмата */
        public static class Globals /* Глобални променливи на програмата */
        {
            public static string username; //username
            public static string name; //name
            public static string password; //password
            public static string typeOfAccount; //typeOfAccount
            public static string mail; //mail
            public static bool isStartedExam = false;
            public static string exam = "";
        }
        public static void Connection() /* Връзка с базата от данни към програмата */
        {
            DBConnection NewConnection = new DBConnection();
            NewConnection.Connection();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = DBConnection.conn;
        }
    }
}
