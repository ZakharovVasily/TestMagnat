using System;
using System.Windows.Forms;
using TestMagnatBL;

namespace TestMagnat.DirectorSetting
{
    public partial class AddPositionForm : Form
    {
        public AddPositionForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка добавления новой должности.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPosButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите добавить должность: " + NewNamePositionTextBox.Text + " ?",
                "Добавление должности", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result != DialogResult.OK) return;

            var connect = new PositionMySql();
            connect.AddPosition(NewNamePositionTextBox.Text);
            this.DialogResult = DialogResult.OK;

        }
    }
}
