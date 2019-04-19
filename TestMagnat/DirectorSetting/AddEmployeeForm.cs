using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestMagnatBL;
using TestMagnatBL.Users.Employee;

namespace TestMagnat.DirectorSetting
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeMySql _connectEmployee;
        private PositionMySql _connectPosition;
        private List<Position> _positionList;

        public AddEmployeeForm()
        {
            InitializeComponent();

            _connectEmployee = new EmployeeMySql();
            _connectPosition = new PositionMySql();

            UpdatePositionComboBox();
        }

        /// <summary>
        /// Кнопка добавления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_connectEmployee.CheckEmployee(UsernameTextBox.Text))
            {
                MessageBox.Show(@"Такой логин уже существует.", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (CheckDataEmpl() == null)
                return;

            if (!_connectEmployee.AddEmployee(CheckDataEmpl()))
                MessageBox.Show(@"Проблемы с подключением к базе данных.", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление должностей в комбобокс.
        /// </summary>
        private void UpdatePositionComboBox()
        {
            _positionList = _connectPosition.GetPosition();

            PositionComboBox.ValueMember = "IdPosition";
            PositionComboBox.DisplayMember = "NamePosition";
            PositionComboBox.DataSource = _positionList;
        }


        /// <summary>
        /// Проверка на ошибки.
        /// </summary>
        /// <returns></returns>
        private Employee CheckDataEmpl()
        {
            var employee = new Employee { IdPosition = PositionComboBox.SelectedIndex };

            try
            {
                employee.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                employee.Name = NameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                employee.Lastname = LastnameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                employee.Username = UsernameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                employee.Password = PasswordTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return employee;
        }
    }
}
