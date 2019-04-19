using System;

namespace TestMagnatBL
{
    // Перед оформлением заказа, должен состоятся замер (заморочки заказчика).

    /// <summary>
    /// Класс замера.
    /// </summary>
    public class Froze
    {
        // В данной программе время представленно не в виде ( 14:00 ), а в виде целочисленного числа 
        // пример : рабочий день начинается с 10:00. _time = 0 (это промежуток с 10:00 до 11:00)
        //                                         _time = 1 (это промежуток с 11:00 до 12:00)
        // Это сделано для удобной реализации пожелания заказчика.

        /// <summary>
        /// Время замера.
        /// </summary>
        private int _time;

        /// <summary>
        /// Город замера.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица замера.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома замера.
        /// </summary>
        private int _houseNumber;

        /// <summary>
        /// Номер Телефона клиента.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Был ли замер.
        /// </summary>
        public bool CheckWasFroze;

        /// <summary>
        /// Номер замера.
        /// </summary>
        public int IdFroze;

        /// <summary>
        /// Время замера.
        /// </summary>
        public int Time
        {
            get => _time;

            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                    throw new ArgumentNullException($"Поле `Время` не может быть пустым.");

                _time = value;
            }
        }

        /// <summary>
        /// Дата замера.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Город замера.
        /// </summary>
        public string City
        {
            get => _city;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException($"Поле `Город` не может быть пустым.");

                _city = value;
            }
        }

        /// <summary>
        /// Улица замера.
        /// </summary>
        public string Street
        {
            get => _street;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException($"Поле `Улица` не может быть пустой.");

                _street = value;
            }
        }

        /// <summary>
        /// Номер дома замера.
        /// </summary>
        public int HouseNumber
        {
            get => _houseNumber;

            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                    throw new ArgumentNullException($"Поле `Номер` дома не может быть пустым.");

                _houseNumber = value;
            }
        }

        /// <summary>
        /// Квартира.
        /// </summary>
        public int Apartment;

        /// <summary>
        /// Номер клиента замера.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }

            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                    throw new ArgumentNullException($"Номер клиента не может быть пустым.");

                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Создал замер.
        /// </summary>
        public string CreateFroze { get; set; }

        /// <summary>
        /// Замерщик.
        /// </summary>
        public string IdGager { get; set; }

        /// <summary>
        /// Комментарий.
        /// </summary>
        public string Comment { get; set; }

        public Froze() { }
    }
}
