using System;
using System.Windows.Forms;
using TestMagnatBL;
using TestMagnatBL.Users.Employee;

namespace TestMagnat.Froze
{
    public partial class AddFrozeForm : Form
    {
        private TestMagnatBL.Froze _currentFroze;

        public TestMagnatBL.Froze CurrentFroze
        {
            get => _currentFroze;

            set
            {
                _currentFroze = value;
                UpdateData();
            }
        }


        public AddFrozeForm()
        {
            InitializeComponent();

            _currentFroze = new TestMagnatBL.Froze();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateData()
        {
            var emplMySql = new EmployeeMySql();

            DateDateTime.Value = _currentFroze.Date;
            GagerTextBox.Text = emplMySql.GetEmpl(int.Parse(_currentFroze.IdGager)).Surname +
                                emplMySql.GetEmpl(int.Parse(_currentFroze.IdGager)).Name;
        }

        /// <summary>
        /// Кнопка Отмена закрывающая форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка добавить замер.
        /// </summary>
        private void AddFrozeButton_Click(object sender, EventArgs e)
        {
            var connectFroze = new FrozeMySql();

            if (!HandlerErorFroze())
                return;

            if (!connectFroze.AddFroze(_currentFroze))
            {
                MessageBox.Show("Проблема с подключением к базе данных.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Обработка ошибок данных замеров.
        /// </summary>
        private bool HandlerErorFroze()
        {
            try
            {
                _currentFroze.City = CityTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

            try
            {
                _currentFroze.Street = StreetTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

            try
            {
                _currentFroze.HouseNumber = int.Parse(NumberHouseTextBox.Text);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

            try
            {
                _currentFroze.Apartment = int.Parse(NumberHouseTextBox.Text);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

            try
            {
                _currentFroze.PhoneNumber = PhoneTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

            try
            {
                _currentFroze.Comment = CommentTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

            _currentFroze.CreateFroze = UserProfile.Data.Surname + " " + UserProfile.Data.Name +
                                   " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            return true;
        }

        private void ApartmentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsControl(e.KeyChar))) return;
            else
                e.Handled = true;
        }
    }
}
