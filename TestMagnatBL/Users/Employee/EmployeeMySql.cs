using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestMagnatBL.Users.Employee
{
    public class EmployeeMySql
    {
        private MySqlConnect _connect;

        public EmployeeMySql()
        {
            _connect = new MySqlConnect();
        }

        /// <summary>
        /// Добавить нового сотрудника в БД.
        /// </summary>
        public bool AddEmployee(Employee newEmpl)
        {
            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            string query = "INSERT INTO empl_base(user_name, password, surname, name, lastname, id_position) " +
               "VALUES ('" + newEmpl.Username + "', '" + newEmpl.Password + "', '" + newEmpl.Surname + "', '" + newEmpl.Name +
                           "', '" + newEmpl.Lastname + "', '" + newEmpl.IdPosition + "');";

            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }

        /// <summary>
        /// Получить базу сотрудников.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmplBase()
        {
            var emplbase = new List<Employee>();

            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            string query = "SELECT * FROM empl_base";

            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var newEmpl = new Employee();

                newEmpl.Id = (int)reader[0];
                newEmpl.Username = reader[1].ToString();
                newEmpl.Password = reader[2].ToString();
                newEmpl.Surname = reader[3].ToString();
                newEmpl.Name = reader[4].ToString();
                newEmpl.Lastname = reader[5].ToString();
                newEmpl.IdPosition = (int)reader[6];

                emplbase.Add(newEmpl);
            }

            _connect.Connection.Close();
            return emplbase;
        }

        /// <summary>
        /// Получить сотрудника.
        /// </summary>
        /// <returns></returns>
        public Employee GetEmpl(int idEmpl)
        {
            var empl = new Employee();

            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            string query = "SELECT * FROM empl_base WHERE id_emplusers = " + idEmpl;

            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                empl.Id = (int)reader[0];
                empl.Username = reader[1].ToString();
                empl.Password = reader[2].ToString();
                empl.Surname = reader[3].ToString();
                empl.Name = reader[4].ToString();
                empl.Lastname = reader[5].ToString();
                empl.IdPosition = (int)reader[6];
            }

            _connect.Connection.Close();
            return empl;
        }

        /// <summary>
        /// Удалить сотрудника из базы.
        /// </summary>
        /// <returns></returns>
        public bool RemoveEmployee(int idEmpl)
        {
            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            string query = "DELETE FROM empl_base WHERE id_emplusers = " + idEmpl + ";";

            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }

        /// <summary>
        /// Обновление данных сотрудника.
        /// </summary>
        /// <returns></returns>
        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            string query = "UPDATE empl_base SET user_name = '" + employee.Username + "', " +
                           "password = '" + employee.Password + "', surname = '" + employee.Surname + "', " +
                           "name = '" + employee.Name + "', lastname = '" + employee.Lastname + "', " +
                           "id_position = " + employee.IdPosition + " " +
                           " WHERE id_emplusers = " + employee.Id + ";";

            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }

        /// <summary>
        /// Проверка на существование логина.
        /// </summary>
        /// <param name="checkUserName"></param>
        /// <returns></returns>
        public bool CheckEmployee(string checkUserName)
        {
            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            // Проверка на существование записи
            string query = "SELECT NOT EXISTS(SELECT * FROM empl_base WHERE user_name = '" + checkUserName + "')";
            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            string countRows = command.ExecuteScalar().ToString();

            if (countRows == "1")
            {
                _connect.Connection.Close();
                return false;
            }
            else
            {
                _connect.Connection.Close();
                return true;
            }
        }

        /// <summary>
        /// Получить данные профиля.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Employee GetDataProfile(string userName)
        {
            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            string queryData = "SELECT * FROM empl_base  WHERE user_name = '" + userName + "';";

            MySqlCommand commandData = new MySqlCommand(queryData, _connect.Connection);
            MySqlDataReader readerPositionData = commandData.ExecuteReader();

            var user = new Employee();

            while (readerPositionData.Read())
            {
                user.Id = (int)readerPositionData[0];
                user.Username = readerPositionData[1].ToString();
                user.Password = readerPositionData[2].ToString();
                user.Surname = readerPositionData[3].ToString();
                user.Name = readerPositionData[4].ToString();
                user.Lastname = readerPositionData[5].ToString();
                user.IdPosition = (int)readerPositionData[6];
            }

            _connect.Connection.Close();
            user.CurrentPosition = GetPositionProfile(user.IdPosition);

            return user;
        }

        /// <summary>
        /// Получение данных о должности.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Position GetPositionProfile(int idPosition)
        {
            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключениек к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            string query = "SELECT * FROM position  WHERE id_position = '" + idPosition + "';";
            MySqlCommand command = new MySqlCommand(query, _connect.Connection);
            MySqlDataReader readerPosition = command.ExecuteReader();

            var position = new Position();

            while (readerPosition.Read())
            {
                position.NamePosition = readerPosition[1].ToString();
                position.CheckAddFroze = (bool)readerPosition[2];
                position.CheckEditFroze = (bool)readerPosition[3];
                position.CheckCommentFroze = (bool)readerPosition[4];
                position.CheckAddOrder = (bool)readerPosition[5];
                position.CheckEditOrder = (bool)readerPosition[6];
                position.CheckMarkFroze = (bool)readerPosition[7];
                position.CheckCommentOrder = (bool)readerPosition[8];
                position.CheckStartPauseOrder = (bool)readerPosition[9];
                position.CheckFinishOrder = (bool)readerPosition[10];
                position.CheckSeePayment = (bool)readerPosition[11];
                position.CheckAddPrepayment = (bool)readerPosition[12];
                position.CheckSeeClient = (bool)readerPosition[13];

            }

            _connect.Connection.Close();

            return position;
        }
    }
}
