using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestMagnatBL.Category
{
    public class CategoryMySql
    {
        private readonly MySqlConnect _connect;

        public CategoryMySql()
        {
            _connect = new MySqlConnect();
        }

        /// <summary>
        /// Добавить ветвь в бд.
        /// </summary>
        public bool AddCategory(Category category)
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

            var query = "INSERT INTO category(name_category, head_node, level) " +
               "VALUES ('" + category.NameNode + "','" + category.HeadNode + "','" + category.LevelNode + "');";

            var command = new MySqlCommand(query, _connect.Connection);
            command.ExecuteNonQuery();

            _connect.Connection.Close();
            return true;
        }

        /// <summary>
        /// Получить базу категорий.
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategory()
        {
            var categoryList = new List<Category>();

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

            var query = "SELECT * FROM category";

            var command = new MySqlCommand(query, _connect.Connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var category = new Category();

                category.IdNode = (int)reader[0];
                category.NameNode = reader[1].ToString();
                category.HeadNode = reader[2].ToString();
                category.LevelNode = (int)reader[3];

                categoryList.Add(category);
            }

            _connect.Connection.Close();
            return categoryList;
        }

        /// <summary>
        /// Удалить категорию.
        /// </summary>
        /// <returns></returns>
        public bool RemoveCategory(string nameCategory, List<Category> categoryList)
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

            foreach (var t in categoryList)
            {
                if (t.NameNode != nameCategory) continue;

                HelpedRemoveCategory(nameCategory, categoryList);

                var query = "DELETE FROM category WHERE id_category = " + t.IdNode + ";";

                var command = new MySqlCommand(query, _connect.Connection);
                command.ExecuteNonQuery();
            }

            _connect.Connection.Close();
            return true;
        }

        private void HelpedRemoveCategory(string currentNode, List<Category> categoryList)
        {
            foreach (var t in categoryList)
            {
                if (t.HeadNode != currentNode) continue;

                HelpedRemoveCategory(t.NameNode, categoryList);
                var query = "DELETE FROM category WHERE id_category = " + t.IdNode + ";";

                var command = new MySqlCommand(query, _connect.Connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
