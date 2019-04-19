using System;

namespace TestMagnatBL
{
    public class Position
    {
        private int _idPosition;

        /// <summary>
        /// Название должности.
        /// </summary>
        private string _namePosition;

        /// <summary>
        /// Проверка добавления замера.
        /// </summary>
        public bool CheckAddFroze;

        /// <summary>
        /// Проверка редактирования замера.
        /// </summary>
        public bool CheckEditFroze;

        /// <summary>
        /// Проверка комментирования замера.
        /// </summary>
        public bool CheckCommentFroze;

        /// <summary>
        /// Проверка состоявшегося замера.
        /// </summary>
        public bool CheckMarkFroze;

        /// <summary>
        /// Проверка оформление заказа.
        /// </summary>
        public bool CheckAddOrder;

        /// <summary>
        /// Проверка редактирования заказа.
        /// </summary>
        public bool CheckEditOrder;

        /// <summary>
        /// Добавить коммент к заказу.
        /// </summary>
        public bool CheckCommentOrder;

        /// <summary>
        /// Приостановить/запустить заказ.
        /// </summary>
        public bool CheckStartPauseOrder;

        /// <summary>
        /// Завершиь заказ.
        /// </summary>
        public bool CheckFinishOrder;

        /// <summary>
        /// Просмотр оплаты.
        /// </summary>
        public bool CheckSeePayment;

        /// <summary>
        /// Добавить предоплату.
        /// </summary>
        public bool CheckAddPrepayment;

        /// <summary>
        /// Посмотреть клиента.
        /// </summary>
        public bool CheckSeeClient;

        /// <summary>
        /// ID должности в базе данных.
        /// </summary>
        public int IdPosition
        {
            get { return _idPosition; }
            set { _idPosition = value; }
        }

        public string NamePosition
        {
            get { return _namePosition; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException($"Название должности не может быть пустым.");

                if (value.Length > 20)
                    throw new ArgumentException("Количество символов в названии должности превышает 20 символов.");

                _namePosition = value;
            }
        }

        public Position()
        {
            NamePosition = "Новая должность";
            CheckAddFroze = false;
            CheckEditFroze = false;
            CheckCommentFroze = false;
            CheckAddOrder = false;
            CheckEditOrder = false;
        }
    }
}
