using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMagnatBL.Users.Client
{
    // Основная работа с данным классом не представляется в урезанной версии.
    // В полной версии клиент заполняется при оформлении заказа.

    /// <summary>
    /// Реализация класса клиента. В полной версии класс содержит 9 полей.
    /// </summary>
    public class Client : User
    {
        private string _city;

        public string City
        {
            get => _city;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"Поле `Город` не может быть пустым.");

                if (value.ToString().Length > 60)
                    throw new ArgumentException($"Поле `Город` не может содержать более 60 символов.");

                _city = value;
            }
        }

        public Client() {}
    }
}
