using System;

namespace TestMagnatBL
{
    public class Workes
    {
        private string _title;

        private string _idEmpl;

        /// <summary>
        /// Фамилия и имя.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"Фамилия и имя не могут быть пустыми.");

                _title = value;
            }
        }

        /// <summary>
        /// Id работника.
        /// </summary>
        public int IdWorkes { get; set; }
    }
}
