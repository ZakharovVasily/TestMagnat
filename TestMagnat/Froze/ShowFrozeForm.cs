using System.Windows.Forms;
using TestMagnatBL;
using TestMagnatBL.Users.Employee;

namespace TestMagnat.Froze
{
    public partial class ShowFrozeForm : Form
    {
        private TestMagnatBL.Froze _currentFroze;

        public TestMagnatBL.Froze CurrentFroze
        {
            get => _currentFroze;
            set { _currentFroze = value; ShowFroze(); }
        }



        public ShowFrozeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показать все данные.
        /// </summary>
        public void ShowFroze()
        {
            var emplMysql = new EmployeeMySql();
            var gager = emplMysql.GetEmpl(int.Parse(CurrentFroze.IdGager));

            CityTextBox.Text = CurrentFroze.City;
            StreetTextBox.Text = CurrentFroze.Street;
            HouseTextBox.Text = CurrentFroze.HouseNumber.ToString();
            AppartmentTextBox.Text = CurrentFroze.Apartment.ToString();
            PhoneNumberTextBox.Text = CurrentFroze.PhoneNumber;
            CommentTextBox.Text = CurrentFroze.Comment;
            CreateLabel.Text += CurrentFroze.CreateFroze;
            GagerLabel.Text += gager.Surname + " " + gager.Name;

            CreateLabel.Text += CurrentFroze.CreateFroze;

            if (CurrentFroze.CheckWasFroze)
            {
                TrueWasFrozeRadioBtn.Checked = true;
            }
            else
            {
                FalseWasFrozeRadioBtn.Checked = true;
            }
        }
    }
}
