using System;
using System.Windows.Forms;
using TestMagnatBL;
using TestMagnatBL.Users.Employee;

namespace TestMagnat.Froze
{
    public partial class ChooseGagerForm : Form
    {
        public int SelectGager { get; set; }

        public ChooseGagerForm()
        {
            InitializeComponent();
            ShowGager();
        }

        private void ShowGager()
        {
            var emplMysql = new EmployeeMySql();

            var emplList = emplMysql.GetEmplBase();

            foreach (var t in emplList)
            {
                if (t.IdPosition == 3)
                {
                    var workes = new Workes() { Title = t.Surname + " " + t.Name, IdWorkes = t.Id };


                    GagerListBox.Items.Add(workes);
                }

                GagerListBox.DisplayMember = "Title";
                GagerListBox.ValueMember = "IdWorkes";
            }
        }

        private void ChooseGagerButton_Click(object sender, EventArgs e)
        {
            ChooseGagerMeth();
        }

        private void GagerListBox_DoubleClick(object sender, EventArgs e)
        {
            ChooseGagerMeth();
        }

        private void ChooseGagerMeth()
        {
            if (GagerListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберете замерщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Workes work = (Workes)GagerListBox.SelectedItem;
            SelectGager = work.IdWorkes;

            DialogResult = DialogResult.OK;
        }
    }
}
