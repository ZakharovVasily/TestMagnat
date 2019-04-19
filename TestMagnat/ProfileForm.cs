using System;
using System.Windows.Forms;
using TestMagnatBL.Users.Employee;

namespace TestMagnat
{
    public partial class ProfileForm : Form
    {
        ToolTip hintButton = new ToolTip();

        private readonly Employee _userProfileConfig = UserProfile.Data;

        public ProfileForm()
        {
            InitializeComponent();

            ShowData();

            PasswordTextBox.UseSystemPasswordChar = true;

            hintButton.SetToolTip(ShowHidePassButton, "Показать пароль");
        }

        /// <summary>
        /// Показать/скрыть кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowHidePassButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                hintButton.SetToolTip(ShowHidePassButton, "Скрыть пароль");
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                hintButton.SetToolTip(ShowHidePassButton, "Показать пароль");
            }
        }

        /// <summary>
        /// Заполнить данные.
        /// </summary>
        private void ShowData()
        {
            IdEmplTextBox.Text = _userProfileConfig.Id.ToString();
            SurnameTextBox.Text = _userProfileConfig.Surname;
            NameTextBox.Text = _userProfileConfig.Name;
            LastnameTextBox.Text = _userProfileConfig.Lastname;
            UsernameTextBox.Text = _userProfileConfig.Username;
            PasswordTextBox.Text = _userProfileConfig.Password;
            PositionTextBox.Text = _userProfileConfig.CurrentPosition.NamePosition;

            var position = _userProfileConfig.CurrentPosition;

            if (position.CheckAddFroze == true)
                TrueAddFroze.Checked = true;
            else
                FalseAddFroze.Checked = true;

            if (position.CheckEditFroze == true)
                TrueEditFroze.Checked = true;
            else
                FalseEditFroze.Checked = true;

            if (position.CheckCommentFroze == true)
                TrueCommentFroze.Checked = true;
            else
                FalseCommentFroze.Checked = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var connect = new EmployeeMySql();

            var user = new Employee();

            _userProfileConfig.Name = NameTextBox.Text;
            _userProfileConfig.Surname = SurnameTextBox.Text;
            _userProfileConfig.Lastname = LastnameTextBox.Text;
            _userProfileConfig.Password = PasswordTextBox.Text;
            _userProfileConfig.Username = UsernameTextBox.Text;

            connect.UpdateEmployee(_userProfileConfig);

            MessageBox.Show("Ваши новые данные сохранены!",
                "Изменение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UserProfile.EnterUserData(_userProfileConfig.Username);

            Close();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
