using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestMagnatBL.Category
{
    public class Category
    {
        private string _nameNode;

        private string _headNode;

        /// <summary>
        /// Название ветви.
        /// </summary>
        public string NameNode
        {
            get => _nameNode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException($"Название ветви не может быть пустым.");

                _nameNode = value;
            }
        }

        /// <summary>
        /// Уровень.
        /// </summary>
        public int LevelNode;

        public int IdNode;

        /// <summary>
        /// Название ветви бати.
        /// </summary>
        public string HeadNode
        {
            get => _headNode;
            set => _headNode = value;
        }

        public Category() { }

        public Category(string name, string head, int level)
        {
            NameNode = name;
            HeadNode = head;
            LevelNode = level;
        } 
    }
}
