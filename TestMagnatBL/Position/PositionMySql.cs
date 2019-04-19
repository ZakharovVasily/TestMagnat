using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TestMagnatBL.Users.Employee;

namespace TestMagnatBL
{
    public class PositionMySql
    {
        private readonly MySqlConnect _connect;

        public PositionMySql()
        {
            _connect = new MySqlConnect();
        }

        /// <summary>
        /// Добавить новую должность в БД.
        /// </summary>
        public bool AddPosition(string newName)
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

            var query = "INSERT INTO `position`(name_position) " +
               "VALUES ('" + newName + "');";

            var command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }


        /// <summary>
        /// Получить базу должностей.
        /// </summary>
        public List<Position> GetPosition()
        {
            var positionList = new List<Position>();

            try
            {
                _connect.Connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проблемы с подключение к базе данных.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            var query = "SELECT * FROM position";

            var command = new MySqlCommand(query, _connect.Connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var newPosition = new Position
                {
                    IdPosition = (int) reader[0],
                    NamePosition = reader[1].ToString(),
                    CheckAddFroze = (bool) reader[2],
                    CheckEditFroze = (bool) reader[3],
                    CheckCommentFroze = (bool) reader[4],
                    CheckAddOrder = (bool) reader[5],
                    CheckEditOrder = (bool) reader[6],
                    CheckMarkFroze = (bool) reader[7],
                    CheckCommentOrder = (bool) reader[8],
                    CheckStartPauseOrder = (bool) reader[9],
                    CheckFinishOrder = (bool) reader[10],
                    CheckSeePayment = (bool) reader[11],
                    CheckAddPrepayment = (bool) reader[12],
                    CheckSeeClient = (bool) reader[13]
                };


                positionList.Add(newPosition);
            }

            _connect.Connection.Close();

            return positionList;
        }

        /// <summary>
        /// Обновить базу должностей.
        /// </summary>
        public bool UpdatePosition(Position position)
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

            var query = "UPDATE `position` SET " +
                       "add_froze = " + position.CheckAddFroze + ", edit_froze = " + position.CheckEditFroze +
                       ", comment_froze = " + position.CheckCommentFroze + ", add_order = " + position.CheckAddOrder +
                       ", edit_order = " + position.CheckEditOrder + ", mark_froze = " +
                       position.CheckMarkFroze + ", comment_order = " + position.CheckCommentOrder +
                       ", pausestart_order = " + position.CheckStartPauseOrder + ", finish_order = " +
                       position.CheckFinishOrder + ", see_payment = " + position.CheckSeePayment +
                       ", add_prepayment = " + position.CheckAddPrepayment + ", see_client = " + position.CheckSeeClient +
                       " WHERE name_position = '" + position.NamePosition + "'";

            var command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }
    }
}
