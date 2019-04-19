using System;
using TestMagnatBL;

namespace TestMagnatBL.Users.Employee
{
    /// <summary>
    /// Реализация класса сотрудников.
    /// </summary>
    public class Employee : User
    {
        private string _userName;

        private string _password;

        // Номер должности. Берется из базы, заполняется директором. 
        public int IdPosition;

        public string Username
        {
            get => _userName; 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"Логин не может быть пустым.");
                }

                _userName = value;
            }
        }

        public string Password
        {
            get =>_password; 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"Пароль не может быть пустым.");
                }

                _password = value;
            }
        }

        public Position CurrentPosition;

        public Employee() { }
    }
}
