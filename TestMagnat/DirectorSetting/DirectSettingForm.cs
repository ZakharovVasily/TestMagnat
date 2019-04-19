using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestMagnatBL;
using TestMagnatBL.Users.Employee;
using TestMagnatBL.Category;

namespace TestMagnat.DirectorSetting
{
    public partial class DirectSettingForm : Form
    {
        private readonly EmployeeMySql _connectEmployee;
        private readonly PositionMySql _connectPosition;
        private List<Position> _positionList;
        private List<Employee> _emplList = new List<Employee>();

        public DirectSettingForm()
        {
            InitializeComponent();

            _connectEmployee = new EmployeeMySql();
            _connectPosition = new PositionMySql();

            UpdatePositionListBox();
            UpdateDataEmplMeth();
            ShowCategory();
        }

        /// <summary>
        /// Обновление радио боксов по выбору должности.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PositionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositionListBox.SelectedIndex <= -1) return;

            if (PositionListBox.Items.Count <= 0) return;

            var positionList = _positionList;
            var position = positionList[PositionListBox.SelectedIndex];

            //Добавить Замер.
            if (position.CheckAddFroze == true)
            {
                TrueAddFroze.Checked = true;
            }
            else
            {
                FalseAddFroze.Checked = true;
            }

            //Редактировать замер.
            if (position.CheckEditFroze == true)
            {
                TrueEditFroze.Checked = true;
            }
            else
            {
                FalseEditFroze.Checked = true;
            }

            //Комментировать замер.
            if (position.CheckCommentFroze == true)
            {
                TrueCommentFroze.Checked = true;
            }
            else
            {
                FalseCommentFroze.Checked = true;
            }

            //Добавить Заказ.
            if (position.CheckAddOrder == true)
            {
                TrueAddOrder.Checked = true;
            }
            else
            {
                FalseAddOrder.Checked = true;
            }

            //Редактировать Заказ.
            if (position.CheckEditOrder == true)
            {
                TrueEditOrder.Checked = true;
            }
            else
            {
                FalseEditOrder.Checked = true;
            }

            if (position.CheckMarkFroze == true)
                TrueMarkFroze.Checked = true;
            else
                FalseMarkFroze.Checked = true;

            if (position.CheckCommentOrder == true)
                TrueCommentOrder.Checked = true;
            else
                FalseCommentOrder.Checked = true;

            if (position.CheckStartPauseOrder == true)
                TruePauseStartOrder.Checked = true;
            else
                FalsePauseStartOrder.Checked = true;

            if (position.CheckFinishOrder == true)
                TrueFinishOrder.Checked = true;
            else
                FalseFinishOrder.Checked = true;

            if (position.CheckSeePayment == true)
                TrueSeePayment.Checked = true;
            else
                FalseSeePayment.Checked = true;

            if (position.CheckAddPrepayment == true)
                TrueAddPrepayment.Checked = true;
            else
                FalseAddPrepayment.Checked = true;

            if (position.CheckSeeClient == true)
                TrueSeeClients.Checked = true;
            else
                FalseSeeClients.Checked = true;
        }

        /// <summary>
        /// Обновление лист бокса.
        /// </summary>
        private void UpdatePositionListBox()
        {
            _positionList = _connectPosition.GetPosition();

            PositionListBox.Items.Clear();

            foreach (var t in _positionList)
            {
                PositionListBox.Items.Add(t.NamePosition);
            }
        }

        #region Обновление радио боксов

        private void TrueAddFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckAddFroze = true;
        }

        private void FalseAddFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckAddFroze = false;
        }

        private void TrueEditFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckEditFroze = true;
        }

        private void FalseEditFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckEditFroze = false;
        }

        private void TrueCommentFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckCommentFroze = true;
        }

        private void FalseCommentFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckCommentFroze = false;
        }

        private void TrueAddOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckAddOrder = true;
        }

        private void FalseAddOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckAddOrder = false;
        }

        private void TrueEditOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckEditOrder = true;
        }

        private void FalseEditOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckEditOrder = false;
        }

        private void TrueMarkFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckMarkFroze = true;
        }

        private void FalseMarkFroze_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckMarkFroze = false;

        }

        private void TrueCommentOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckCommentOrder = true;

        }

        private void FalseCommentOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckCommentOrder = false;

        }

        private void TruePauseStartOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckStartPauseOrder = true;

        }

        private void FalsePauseStartOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckStartPauseOrder = false;
        }

        private void TrueFinishOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckFinishOrder = true;
        }

        private void FalseFinishOrder_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckFinishOrder = false;
        }

        private void TrueSeePayment_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckSeePayment = true;
        }

        private void FalseSeePayment_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckSeePayment = false;
        }

        private void TrueAddPrepayment_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckAddPrepayment = true;
        }

        private void FalseAddPrepayment_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckAddPrepayment = false;
        }

        private void TrueSeeClients_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckSeeClient = true;
        }

        private void FalseSeeClients_CheckedChanged(object sender, EventArgs e)
        {
            _positionList[PositionListBox.SelectedIndex].CheckSeeClient = false;
        }

        #endregion

        #region Работа с сотрудниками

        /// <summary>
        /// Загрузить данные сотрудников из базы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateData_Click(object sender, EventArgs e)
        {
            UpdateDataEmplMeth();
        }

        /// <summary>
        /// Метод загрузки данных сотрудников из базы.
        /// </summary>
        public void UpdateDataEmplMeth()
        {
            EmplBaseDataGridView.Rows.Clear();

            _emplList = _connectEmployee.GetEmplBase();

            foreach (var t in _emplList)
                EmplBaseDataGridView.Rows.Add(t.Id, t.Username, t.Password, t.Surname, t.Name, t.Lastname);
        }

        /// <summary>
        /// Кнопка добавить нового сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmplButton_Click(object sender, EventArgs e)
        {
            AddEmplMeth();
        }

        /// <summary>
        /// Метод добавления сотрудника.
        /// </summary>
        private void AddEmplMeth()
        {
            var addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();

            UpdateDataEmplMeth();
        }

        /// <summary>
        /// Кнопка Удалить сотрудника из базы по кнопке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveEmplButton_Click(object sender, EventArgs e)
        {
            RemoveEmplMeth();
        }

        /// <summary>
        /// Метод удаления сотрудника.
        /// </summary>
        private void RemoveEmplMeth()
        {
            var surnameSelectEmpl = EmplBaseDataGridView.CurrentRow.Cells[1].Value.ToString();
            var nameSelectEmpl = EmplBaseDataGridView.CurrentRow.Cells[2].Value.ToString();
            var idSelectEmpl = int.Parse(EmplBaseDataGridView.CurrentRow.Cells[0].Value.ToString());

            var result = MessageBox.Show("Вы уверены что хотите удалить сотрудника: " + surnameSelectEmpl + " "
                                                  + nameSelectEmpl + "?", "Удаление сотрудника", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.Cancel) return;

            if (!_connectEmployee.RemoveEmployee(idSelectEmpl))
            {
                MessageBox.Show("Проблема с базой даннных, попробуйте еще раз.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            UpdateDataEmplMeth();
        }

        /// <summary>
        /// Показать данные сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowEmlpButton_Click(object sender, EventArgs e)
        {
            var showEmplForm = new ShowEmployeeForm();
            var idSelectEmpl = int.Parse(EmplBaseDataGridView.CurrentRow.Cells[0].Value.ToString());

            showEmplForm.SelectEmployee = GetEmpl(idSelectEmpl);

            showEmplForm.Show();
        }

        /// <summary>
        /// Получение сотрудника по его id.
        /// </summary>
        /// <param name="idEmpl"></param>
        /// <returns></returns>
        private Employee GetEmpl(int idEmpl)
        {
            foreach (var t in _emplList)
            {
                if (idEmpl == t.Id)
                    return t;
            }

            return null;
        }

        /// <summary>
        /// Просмотр сотрудника по клавише Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmplBaseDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var showEmplForm = new ShowEmployeeForm();
            int idSelectEmpl = int.Parse(EmplBaseDataGridView.CurrentRow.Cells[0].Value.ToString());

            showEmplForm.SelectEmployee = GetEmpl(idSelectEmpl);
            showEmplForm.Show();
        }

        /// <summary>
        /// Контекстное меню, добавить сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmplMeth();
        }

        /// <summary>
        /// Контекстное меню, посмотреть сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowEmplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showEmplForm = new ShowEmployeeForm();
            int idSelectEmpl = int.Parse(EmplBaseDataGridView.CurrentRow.Cells[0].Value.ToString());

            showEmplForm.SelectEmployee = GetEmpl(idSelectEmpl);
            showEmplForm.Show();
        }

        /// <summary>
        /// Контекстное меню, удалить сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveEmplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEmplMeth();
        }

        /// <summary>
        /// Просмотр сотрудника по двойному клику мыши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmplBaseDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var showEmplForm = new ShowEmployeeForm();
            int idSelectEmpl = int.Parse(EmplBaseDataGridView.CurrentRow.Cells[0].Value.ToString());

            showEmplForm.SelectEmployee = GetEmpl(idSelectEmpl);
            showEmplForm.Show();
        }

        #endregion

        #region Работа с должностями

        /// <summary>
        /// Добавить должность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPosition_Click(object sender, EventArgs e)
        {
            var addPositionForm = new AddPositionForm();

            if (addPositionForm.ShowDialog() != DialogResult.OK) return;

            UpdatePositionListBox();
        }

        /// <summary>
        /// Сохранить настройки должности.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSettingPosition_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите сохранить настройки?",
                "Сохранить настройки", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel) return;

            var positionList = _positionList;
            var position = positionList[PositionListBox.SelectedIndex];

            if (!_connectPosition.UpdatePosition(position))
                MessageBox.Show("Ошибка, попробуйте еще раз.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Данные должности " + position.NamePosition + " сохранены.",
                "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdatePositionListBox();
        }

        #endregion

        #region Работа с категориями

        /// <summary>
        /// Загрузить и показать категории.
        /// </summary>
        private void ShowCategory()
        {
            var connect = new CategoryMySql();

            var categoryList = connect.GetCategory();

            foreach (var t in categoryList)
            {
                if (t.LevelNode != 1) continue;

                var firstNode = new TreeNode(t.NameNode);

                Helper.HelpedShowCategory(t.NameNode, categoryList, firstNode);

                CategoryTreeView.Nodes.Add(firstNode);
            }
        }

        /// <summary>
        /// Добавить корень.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBaseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameNodeTextBox.Text))
            {
                MessageBox.Show("Введите пожалуйста название.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var newNode = new TreeNode(NameNodeTextBox.Text);
            CategoryTreeView.Nodes.Add(newNode);

            var category = new Category(NameNodeTextBox.Text, "", 1);
            var connect = new CategoryMySql();

            connect.AddCategory(category);

            NameNodeTextBox.Clear();
        }

        /// <summary>
        /// Добавить ветвь.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBranchBtn_Click(object sender, EventArgs e)
        {
            if (CategoryTreeView.SelectedNode == null)
            {
                MessageBox.Show("Ветвь не выбрана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(NameNodeTextBox.Text))
            {
                MessageBox.Show("Введите пожалуйста название.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var newNode = CategoryTreeView.SelectedNode;
            newNode.Nodes.Add(NameNodeTextBox.Text);
            newNode.Expand();

            var category = new Category(NameNodeTextBox.Text, CategoryTreeView.SelectedNode.Text, 0);
            var connect = new CategoryMySql();

            connect.AddCategory(category);

            NameNodeTextBox.Clear();
        }

        /// <summary>
        /// Изменить название.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNodeBtn_Click(object sender, EventArgs e)
        {
            if (CategoryTreeView.SelectedNode == null)
            {
                MessageBox.Show("Ветвь не выбрана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(NameNodeTextBox.Text))
            {
                MessageBox.Show("Введите пожалуйста название.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var newNode = CategoryTreeView.SelectedNode;
            newNode.Text = NameNodeTextBox.Text;

            NameNodeTextBox.Clear();
        }

        /// <summary>
        /// Удалить ветвь.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveBranchBtn_Click(object sender, EventArgs e)
        {
            if (CategoryTreeView.SelectedNode == null)
            {
                MessageBox.Show("Ветвь не выбрана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить ветвь " + CategoryTreeView.SelectedNode.Text +
                " и все ее дочерние ветви?", "Удаление ветви", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
                return;

            var connect = new CategoryMySql();
            connect.RemoveCategory(CategoryTreeView.SelectedNode.Text, connect.GetCategory());

            var newNode = CategoryTreeView.SelectedNode;
            newNode.Remove();

            Show();
        }

        /// <summary>
        /// Раскрыть все ветви.
        /// </summary>
        private void ShowAllCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryTreeView.ExpandAll();

            ShowAllCategoryBtn.Visible = false;
            HideCategoryBtn.Visible = true;
        }

        /// <summary>
        /// Скрыть все ветви.
        /// </summary>
        private void HideCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryTreeView.CollapseAll();

            HideCategoryBtn.Visible = false;
            ShowAllCategoryBtn.Visible = true;
        }

        #endregion
    }
}
