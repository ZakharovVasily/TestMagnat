using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TestMagnatBL
{
    /// <summary>
    /// Класс для работы с базой данных.
    /// </summary>
    public class MySqlConnect
    {       
        /// <summary>
        /// Данные для подключения к БД.     
        /// </summary>
        private static string _serverName = @"test-magnat";
        private static string _userName = "userAF6";
        private static string _dbName = "magnat_nk";
        private static string _port = "3306";
        private static string _password = "IK4RDfPxHWfATM46";

        /// <summary>
        /// Строка для подключения к БД.
        /// </summary>
        public static string ConnectString = "server=" + _serverName + ";" +
            "user=" + _userName + ";" + "database=" + _dbName + ";" +
                                         "port=" + _port + ";password=" + _password + ";charset=utf8;";


        /// <summary>
        /// Поле подключения к БД.
        /// </summary>
        public MySqlConnection Connection = new MySqlConnection(ConnectString);

        /// <summary>
        /// Проверка на работоспособность сервера. Если сервер отключен по тех. причинам, выводится сообщение из БД.
        /// </summary>
        /// <returns></returns>
        public bool GetConfig()
        {
            // Подключение к БД
            try
            {
                Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            string query = "SELECT access FROM config WHERE name_config = 'config_programm'";

            MySqlCommand command = new MySqlCommand(query, Connection);

            bool reader = (bool)command.ExecuteScalar();

            if (reader == false)
            {
                query = "SELECT message_users FROM config WHERE name_config = 'config_programm'";
                command = new MySqlCommand(query, Connection);
                string readerError = command.ExecuteScalar().ToString();

                MessageBox.Show(readerError, "Ошибка", MessageBoxButtons.OK);
                Connection.Close();
                return false;
            }

            Connection.Close();
            return true;
        }

        /// <summary>
        /// Вход для сотрудника.
        /// </summary>
        /// <returns></returns>
        public bool EmployeeEntry(string userName, string password)
        {
            try
            {
                Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            // Проверка на существование записи
            string query = "SELECT NOT EXISTS(SELECT * FROM empl_base WHERE user_name = '" + userName + "')";
            MySqlCommand command = new MySqlCommand(query, Connection);
            string countRows = command.ExecuteScalar().ToString();

            if (countRows == "1")
            {
                return false;
            }

            //Основной запрос
            query = "SELECT password FROM empl_base WHERE user_name = '" + userName + "'";

            command = new MySqlCommand(query, Connection);

            string reader = command.ExecuteScalar().ToString();

            if (reader == password)
            {
                Connection.Close();
                return true;
            }
            else
            {
                Connection.Close();
                return false;
            }
        }
    }
}
