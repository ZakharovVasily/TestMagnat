using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestMagnatBL
{
    public class FrozeMySql
    {
        private readonly MySqlConnect _connect;

        public FrozeMySql()
        {
            _connect = new MySqlConnect();
        }

        /// <summary>
        /// Добавить новый замер в БД.
        /// </summary>
        public bool AddFroze(Froze froze)
        {
            var time = froze.Time;
            var date = froze.Date.ToString("dd/MM/yyyy");
            var city = froze.City;
            var street = froze.Street;
            var houseNumber = froze.HouseNumber;
            var apartment = froze.Apartment;
            var phoneNumber = froze.PhoneNumber;
            var comment = froze.Comment;
            var idGager = froze.IdGager;
            var create = froze.CreateFroze;

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

            string query = "INSERT INTO `froze_base` ( " +
               "`time` , `date` , `city` ,`street` , `house_number` ,`apartment` , `phone_number` , `coment` ,`id_gager`" +
                ",`create`)" +
            "VALUES(" + time + ", '" + date + "', '" + city + "', '" + street + "', " + houseNumber + ", " + apartment +
                ", '" + phoneNumber + "', '" + comment + "', '" + idGager + "', '" + create + "');";

            var command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }

        /// <summary>
        /// Получить базу замеров.
        /// </summary>
        /// <returns></returns>
        public List<Froze> GetFrozeBase(string idGager, string date)
        {
            // Подключение к БД
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

            var query = "SELECT * FROM froze_base WHERE id_gager = '" + idGager + "' AND date = '" + date + "'";

            var command = new MySqlCommand(query, _connect.Connection);
            var reader = command.ExecuteReader();

            var frozeBase = new List<Froze>();

            while (reader.Read())
            {
                var froze = new Froze {IdFroze = (int) reader[0], Time = (int) reader[1]};

                DateTime.TryParseExact(reader[3].ToString(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var newDate);
                froze.Date = newDate;

                froze.City = reader[3].ToString();
                froze.Street = reader[4].ToString();
                froze.HouseNumber = (int)reader[5];
                froze.PhoneNumber = reader[7].ToString();
                froze.Apartment = (int)reader[6];
                froze.Comment = reader[8].ToString();
                froze.CheckWasFroze = (bool)reader[12];
                froze.IdGager = reader[14].ToString();
                froze.CreateFroze = reader[16].ToString();

                frozeBase.Add(froze);
            }

            _connect.Connection.Close();
            return frozeBase;
        }


        /// <summary>
        /// Получить замер.
        /// </summary>
        /// <returns></returns>
        public Froze GetFroze(int idGager, string date, int time)
        {
            // Подключение к БД
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

            var query = "SELECT * FROM froze_base WHERE id_gager = '" + idGager + "' AND date = '" + date + "' AND time = " + time;

            var command = new MySqlCommand(query, _connect.Connection);
            var reader = command.ExecuteReader();

            var froze = new Froze();

            while (reader.Read())
            {
                froze.IdFroze = (int)reader[0];
                froze.Time = (int)reader[1];


                DateTime.TryParseExact(reader[3].ToString(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var newDate);
                newDate = froze.Date;

                froze.City = reader[3].ToString();
                froze.Street = reader[4].ToString();
                froze.HouseNumber = (int)reader[5];
                froze.PhoneNumber = reader[7].ToString();
                froze.Apartment = (int)reader[6];
                froze.Comment = reader[8].ToString();
                froze.CheckWasFroze = (bool)reader[12];
                froze.IdGager = reader[14].ToString();
                froze.CreateFroze = reader[16].ToString();
            }

            _connect.Connection.Close();
            return froze;
        }

        /// <summary>
        /// Обновление комментария.
        /// </summary>
        /// <returns></returns>
        public bool UpdateComment(int idFroze, string newComment)
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

            var query = "UPDATE froze_base SET comment = '" + newComment + "'  WHERE id_froze = " + idFroze + ";";

            var command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }
    }
}
