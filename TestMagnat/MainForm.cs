using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestMagnat.DirectorSetting;
using TestMagnat.Froze;
using TestMagnatBL.Users.Employee;
using TestMagnatBL;

namespace TestMagnat
{
    public partial class MainForm : Form
    {
        #region Переменные для динамических таблиц замеров

        private int _countGager = 0;

        private List<int> _gager = new List<int>();
        private List<DateTimePicker> _dateTimePickerList = new List<DateTimePicker>();
        private List<TextBox> _nameGagerTextBoxList = new List<TextBox>();
        private List<ComboBox> _directionComboBoxList = new List<ComboBox>();
        private List<DataGridView> _showGagerDataGridViewList = new List<DataGridView>();

        #endregion

        public MainForm()
        {
            InitializeComponent();
            AccessLimitation();
        }

        #region Работа с замерами

        /// <summary>
        /// Показ замеров.
        /// </summary>
        private void ShowFrozeButton_Click(object sender, EventArgs e)
        {
            TextNameLabel.Text = "Замеры";

            MainPanel.Controls.Clear();
            _countGager = 0;

            ShowButtonAddFroze(0);
        }

        /// <summary>
        /// Динамическая кнопка "Добавить замерщика".
        /// </summary>
        private void ShowButtonAddFroze(int height)
        {
            var addFrozeButton = new Button
            {
                Location = new System.Drawing.Point(3, height + 3),
                Name = "ChoseGagerBtn",
                Size = new System.Drawing.Size(150, 23),
                TabIndex = 3,
                Text = "Выбрать замерщика",
                UseVisualStyleBackColor = true
            };

            addFrozeButton.Click += new EventHandler(AddTableButton_Click);
            MainPanel.Controls.Add(addFrozeButton);
        }

        /// <summary>
        /// Добавить новую таблицу замеров.
        /// </summary>
        private void AddTableButton_Click(object sender, EventArgs e)
        {
            var chooseGagerForm = new ChooseGagerForm();

            if (chooseGagerForm.ShowDialog() == DialogResult.OK)
                _gager.Add(chooseGagerForm.SelectGager);
            else
                return;

            MainPanel.Controls.Clear();
            _dateTimePickerList.Clear();
            _showGagerDataGridViewList.Clear();
            _directionComboBoxList.Clear();
            _nameGagerTextBoxList.Clear();

            _countGager++;

            for (var i = 0; i < _countGager; i++)
            {
                bool addBtn = (i + 1) == _countGager;

                AddItemsTableFroze(i * 320, addBtn, i, _gager[i]);
            }

            // Глянуть
            for (var i = 0; i < _countGager; i++)
            {
                MainPanel.Controls.Add(_dateTimePickerList[i]);
                MainPanel.Controls.Add(_showGagerDataGridViewList[i]);
                MainPanel.Controls.Add(_directionComboBoxList[i]);
                MainPanel.Controls.Add(_nameGagerTextBoxList[i]);

                _showGagerDataGridViewList[i].CurrentCell = null;
            }
        }

        /// <summary>
        /// Метод добавления элементов новой таблицы замеров.
        /// </summary>
        private void AddItemsTableFroze(int height, bool addBtn, int count, int idGager)
        {

            var newDateTimePicker = new DateTimePicker();
            var nameGagerTextBox = new TextBox();
            var directionComboBox = new ComboBox();
            var showGagerDataGridView = new DataGridView();
            var numberColumn = new DataGridViewTextBoxColumn();
            var timeColumn = new DataGridViewTextBoxColumn();
            var cityColumn = new DataGridViewTextBoxColumn();
            var streetColumn = new DataGridViewTextBoxColumn();
            var homeColumn = new DataGridViewTextBoxColumn();
            var apartmentColumn = new DataGridViewTextBoxColumn();
            var phoneColumn = new DataGridViewTextBoxColumn();
            var commentColumn = new DataGridViewTextBoxColumn();
            var frozeColumn = new DataGridViewTextBoxColumn();

            newDateTimePicker.CustomFormat = "dd/MM/yyyy";
            newDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            newDateTimePicker.Location = new System.Drawing.Point(5, height + 4);
            newDateTimePicker.Name = "dateTimePicker" + count.ToString();
            newDateTimePicker.Size = new System.Drawing.Size(84, 20);
            newDateTimePicker.TabIndex = 4;
            newDateTimePicker.ValueChanged += new System.EventHandler(this.ChangeDateTime_ValueChanged);
            _dateTimePickerList.Add(newDateTimePicker);

            var emplMysql = new EmployeeMySql();
            var empl = emplMysql.GetEmpl(idGager);

            nameGagerTextBox.Location = new System.Drawing.Point(5, height + 35);
            nameGagerTextBox.Name = "GagerNameTextBox" + count.ToString();
            nameGagerTextBox.Size = new System.Drawing.Size(149, 23);
            nameGagerTextBox.TabIndex = 5;
            nameGagerTextBox.Text = empl.Surname + " " + empl.Name;
            nameGagerTextBox.ReadOnly = true;
            _nameGagerTextBoxList.Add(nameGagerTextBox);

            directionComboBox.FormattingEnabled = true;
            directionComboBox.Location = new System.Drawing.Point(160, height + 37);
            directionComboBox.Name = "comboBox" + count.ToString();
            directionComboBox.Size = new System.Drawing.Size(152, 21);
            directionComboBox.TabIndex = 6;
            directionComboBox.Text = "Выбрать направление";
            _directionComboBoxList.Add(directionComboBox);

            showGagerDataGridView.Anchor = (AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right);
            showGagerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showGagerDataGridView.BorderStyle = BorderStyle.None;
            showGagerDataGridView.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showGagerDataGridView.AllowUserToDeleteRows = false;
            showGagerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showGagerDataGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                numberColumn,
                timeColumn,
                cityColumn,
                streetColumn,
                homeColumn,
                apartmentColumn,
                phoneColumn,
                commentColumn,
                frozeColumn

        });
            showGagerDataGridView.Location = new System.Drawing.Point(5, height + 64);
            showGagerDataGridView.Name = "dataGridView" + count.ToString();
            showGagerDataGridView.Size = new System.Drawing.Size(MainPanel.Size.Width, 204);
            showGagerDataGridView.TabIndex = 7;
            showGagerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showGagerDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            showGagerDataGridView.MultiSelect = false;
            _showGagerDataGridViewList.Add(showGagerDataGridView);
            showGagerDataGridView.MouseDoubleClick += new MouseEventHandler(ShowFrozeDataGridView_MouseDoubleClick);
            showGagerDataGridView.MouseClick += new MouseEventHandler(ShowFrozeDataGridView_MouseClick);

            UpdateDataSelectTableFroze(showGagerDataGridView, idGager, DateTime.Now);


            numberColumn.HeaderText = "№";
            numberColumn.Name = "Column1";
            numberColumn.ReadOnly = true;
            numberColumn.FillWeight = 30;

            timeColumn.HeaderText = "Время";
            timeColumn.Name = "Column2";
            timeColumn.ReadOnly = true;
            timeColumn.FillWeight = 60;

            cityColumn.HeaderText = "Город";
            cityColumn.Name = "Column3";
            cityColumn.ReadOnly = true;
            cityColumn.FillWeight = 80;

            streetColumn.HeaderText = "Улица";
            streetColumn.Name = "Column4";
            streetColumn.ReadOnly = true;

            homeColumn.HeaderText = "Дом";
            homeColumn.Name = "Column5";
            homeColumn.ReadOnly = true;
            homeColumn.FillWeight = 40;

            apartmentColumn.HeaderText = "Квартира";
            apartmentColumn.Name = "Column6";
            apartmentColumn.ReadOnly = true;
            apartmentColumn.FillWeight = 40;

            phoneColumn.HeaderText = "Телефон";
            phoneColumn.Name = "Column7";
            phoneColumn.ReadOnly = true;
            phoneColumn.FillWeight = 80;

            commentColumn.HeaderText = "Комментарий";
            commentColumn.Name = "Column8";
            commentColumn.ReadOnly = true;

            frozeColumn.HeaderText = "";
            frozeColumn.Name = "Column8";
            frozeColumn.ReadOnly = true;
            frozeColumn.Visible = false;

            if (addBtn)
                ShowButtonAddFroze(height + 290);
        }

        /// <summary>
        /// Просмотр замера по двойному клику мыши.
        /// </summary>
        private void ShowFrozeDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dataGrid = SelectedDataGridViewFroze(sender);

            if ((TestMagnatBL.Froze) dataGrid.SelectedCells[8].Value != null)
            {
                var showFrozeForm = new ShowFrozeForm();
                showFrozeForm.CurrentFroze = (TestMagnatBL.Froze) dataGrid.SelectedCells[8].Value;
                showFrozeForm.Show();
            }
            else
            {
                if (!UserProfile.Data.CurrentPosition.CheckAddFroze)
                {
                    MessageBox.Show("Вы не можете добавить новый замер.", "Ошибка", MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);

                    return;
                }

                int index = _showGagerDataGridViewList.FindIndex(t => t == dataGrid);

                var newFroze = new TestMagnatBL.Froze();
                newFroze.Date = _dateTimePickerList[index].Value;
                newFroze.IdGager = _gager[index].ToString();
                newFroze.Time = int.Parse(dataGrid.SelectedCells[0].Value.ToString());

                var addFrozeForm = new AddFrozeForm();
                addFrozeForm.CurrentFroze = newFroze;

                if (addFrozeForm.ShowDialog() == DialogResult.OK)
                    UpdateDataSelectTableFroze(dataGrid, _gager[index], _dateTimePickerList[index].Value);
            }
        }

        /// <summary>
        /// Снять выделение со всех кроме клика.
        /// </summary>
        private void ShowFrozeDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            var dataGrid = SelectedDataGridViewFroze(sender);

            for (int i = 0; i < _showGagerDataGridViewList.Count; i++)
            {
                if (_showGagerDataGridViewList[i].Name != dataGrid.Name)
                {
                    _showGagerDataGridViewList[i].CurrentCell = null;
                }
            }
        }

        /// <summary>
        /// Обновить данные выбранной таблицы замеров.
        /// </summary>
        private void UpdateDataSelectTableFroze(DataGridView selectTable, int idGager, DateTime date)
        {
            selectTable.Rows.Clear();
            selectTable.Rows.Add(8);

            for (int i = 0; i < 9; i++)
            {
                selectTable.Rows[i].Cells[0].Value = (i + 1).ToString();
                selectTable.Rows[i].Cells[1].Value = (10 + i).ToString() + ":00 - " + (11 + i).ToString() + ":00";
            }

            var frozeMysql = new FrozeMySql();
            var frozeList = frozeMysql.GetFrozeBase(idGager.ToString(), date.ToString("dd/MM/yyyy"));

            foreach (var t in frozeList)
            {
                selectTable.Rows[t.Time].Cells[2].Value = t.City;
                selectTable.Rows[t.Time].Cells[3].Value = t.Street;
                selectTable.Rows[t.Time].Cells[4].Value = t.HouseNumber;
                selectTable.Rows[t.Time].Cells[5].Value = t.Apartment;
                selectTable.Rows[t.Time].Cells[6].Value = t.PhoneNumber;
                selectTable.Rows[t.Time].Cells[7].Value = t.Comment;
                selectTable.Rows[t.Time].Cells[8].Value = t;
            }
        }

        /// <summary>
        /// Обновить данные выбранной таблицы замеров.
        /// </summary>
        private void UpdateDataSelectTableFroze(DataGridView selectTable)
        {
            int index = 0;

            for (var i = 0; i < _dateTimePickerList.Count; i++)
            {
                if (_dateTimePickerList[i].Name == selectTable.Name)
                {
                    index = i;
                }
            }

            UpdateDataSelectTableFroze(_showGagerDataGridViewList[index], _gager[index], _dateTimePickerList[index].Value);

            selectTable.Rows.Clear();
            selectTable.Rows.Add(8);

            for (int i = 0; i < 9; i++)
            {
                selectTable.Rows[i].Cells[0].Value = (i + 1).ToString();
                selectTable.Rows[i].Cells[1].Value = (10 + i).ToString() + ":00 - " + (11 + i).ToString() + ":00";
            }

            var frozeMysql = new FrozeMySql();
            var frozeList = frozeMysql.GetFrozeBase(selectTable.ToString(), _dateTimePickerList[index].Value.ToString("dd/MM/yyyy"));

            foreach (var t in frozeList)
            {
                selectTable.Rows[t.Time].Cells[2].Value = t.City;
                selectTable.Rows[t.Time].Cells[3].Value = t.Street;
                selectTable.Rows[t.Time].Cells[4].Value = t.HouseNumber;
                selectTable.Rows[t.Time].Cells[5].Value = t.Apartment;
                selectTable.Rows[t.Time].Cells[6].Value = t.PhoneNumber;
                selectTable.Rows[t.Time].Cells[7].Value = t.Comment;
                selectTable.Rows[t.Time].Cells[8].Value = t;
            }
        }

        /// <summary>
        /// Выбор даты замера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDateTime_ValueChanged(object sender, EventArgs e)
        {
            int index = 0;

            for (var i = 0; i < _dateTimePickerList.Count; i++)
            {
                if (_dateTimePickerList[i].Name == (sender as DataGridView)?.Name)
                {
                    index = i;
                }
            }

            UpdateDataSelectTableFroze(_showGagerDataGridViewList[index], _gager[index], _dateTimePickerList[index].Value);
        }

        /// <summary>
        /// Возращает выбранную таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private DataGridView SelectedDataGridViewFroze(object sender)
        {
            var dataGrid = new DataGridView();

            foreach (var t in _showGagerDataGridViewList)
            {
                if (t.Name == (sender as DataGridView).Name)
                {
                    dataGrid = t;
                }
            }

            return dataGrid;
        }

        #endregion

        /// <summary>
        /// Открыть настройки директора. Кнопка меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirectSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var setting = new DirectSettingForm();
            setting.Show();
        }

        /// <summary>
        /// Кнопка просмотра своего профиля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showProfileForm = new ProfileForm();

            showProfileForm.Show();
        }

        /// <summary>
        /// Кнопка закрытия программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ограничение доступа.
        /// </summary>
        private void AccessLimitation()
        {
            if (UserProfile.Data.CurrentPosition.NamePosition != "Директор")
                DirectSettingToolStripMenuItem.Visible = false;
        }
    }
}
