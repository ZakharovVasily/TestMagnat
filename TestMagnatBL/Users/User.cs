using System;

namespace TestMagnatBL.Users
{
    /// <summary>
    /// Абстрактный для реализации классов пользователей и клиентов.
    /// </summary>
    public abstract class User
    {
        private int _id;

        private string _name;

        private string _surname;

        private string _lastname;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"Поле `Имя` не может быть пустым.");

                if (value.ToString().Length > 50)
                    throw new ArgumentException($"Поле `Имя` не может содержать более 50 символов.");

                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"Поле `Фамилия` не может быть пустым.");

                if (value.ToString().Length > 50)
                    throw new ArgumentException($"Поле `Фамилия` не может состоять более 50 символов.");

                _surname = value;
            }
        }

        public string Lastname
        {
            get => _lastname;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"Поле `Очество` не может быть пустым.");

                if (value.ToString().Length > 50)
                    throw new ArgumentException($"Поле `Очество` не может состоять более 50 символов.");

                _lastname = value;
            }
        }
    }
}
