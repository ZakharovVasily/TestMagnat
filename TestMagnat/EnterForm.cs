using System;
using System.Windows.Forms;
using TestMagnatBL;

namespace TestMagnat
{
    public partial class EnterForm : Form
    {
        /// <summary>
        /// Поле для работы с БД.
        /// </summary>
        private MySqlConnect _connect;

        public EnterForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _connect = new MySqlConnect();

            if (!_connect.GetConfig())
                return;

            if (_connect.EmployeeEntry(LoginTextBox.Text, PasswordTextBox.Text))
            {
                UserProfile.EnterUserData(LoginTextBox.Text);

                MainForm mainForm = new MainForm();
                this.Hide();

                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны. Попробуйте еще раз или обратитесь к директору.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            this.Close();
        }
    }
}
