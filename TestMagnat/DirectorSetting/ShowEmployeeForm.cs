using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestMagnatBL;
using TestMagnatBL.Users.Employee;

namespace TestMagnat.DirectorSetting
{
    public partial class ShowEmployeeForm : Form
    {
        private Employee _electEmployee;
        private EmployeeMySql _connectEmployee;
        private PositionMySql _connectPosition;
        private List<Position> _positionList;

        public Employee SelectEmployee
        {
            get => _electEmployee;
            set
            {
                _connectEmployee = new EmployeeMySql();
                _electEmployee = value;
                ShowData();
            }
        }

        public ShowEmployeeForm()
        {
            InitializeComponent();

            _connectPosition = new PositionMySql();
            _positionList = new List<Position>();

            SaveButton.Visible = false;

            SurnameTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            LastnameTextBox.Enabled = false;
            UsernameTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;
            PositionComboBox.Enabled = false;

            UpdataPositionComboBox();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Метод вывод данных.
        /// </summary>
        private void ShowData()
        {
            if (SelectEmployee == null)
                return;

            IdEmplTextBox.Text = SelectEmployee.Id.ToString();
            SurnameTextBox.Text = SelectEmployee.Surname;
            NameTextBox.Text = SelectEmployee.Name;
            LastnameTextBox.Text = SelectEmployee.Lastname;
            UsernameTextBox.Text = SelectEmployee.Username;
            PasswordTextBox.Text = SelectEmployee.Password;
            PositionComboBox.SelectedItem = PositionComboBox.Items[SelectEmployee.IdPosition - 1];
        }

        /// <summary>
        /// Добавление должностей в комбобокс.
        /// </summary>
        private void UpdataPositionComboBox()
        {
            _positionList = _connectPosition.GetPosition();

            PositionComboBox.DataSource = _positionList;
            PositionComboBox.DisplayMember = "NamePosition";
            PositionComboBox.ValueMember = "IdPosition";
        }

        /// <summary>
        /// Проверка на ошибки.
        /// </summary>
        /// <returns></returns>
        private bool CheckDataEmpl()
        {
            SelectEmployee.Id = int.Parse(IdEmplTextBox.Text);
            SelectEmployee.IdPosition = int.Parse(PositionComboBox.SelectedValue.ToString());

            try
            {
                SelectEmployee.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                SelectEmployee.Name = NameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                SelectEmployee.Lastname = LastnameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                SelectEmployee.Username = UsernameTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                SelectEmployee.Password = PasswordTextBox.Text;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeButton.Visible = false;
            SaveButton.Visible = true;

            SurnameTextBox.Enabled = true;
            NameTextBox.Enabled = true;
            LastnameTextBox.Enabled = true;
            UsernameTextBox.Enabled = true;
            PasswordTextBox.Enabled = true;
            PositionComboBox.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckDataEmpl())
                return;

            _connectEmployee.UpdateEmployee(_electEmployee);
            Close();
        }
    }
}
