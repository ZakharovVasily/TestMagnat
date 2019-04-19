namespace TestMagnat
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.CommentFrozeGroupBox = new System.Windows.Forms.GroupBox();
            this.FalseCommentFroze = new System.Windows.Forms.RadioButton();
            this.TrueCommentFroze = new System.Windows.Forms.RadioButton();
            this.EditFrozeSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.FalseEditFroze = new System.Windows.Forms.RadioButton();
            this.TrueEditFroze = new System.Windows.Forms.RadioButton();
            this.AddFrozeSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.FalseAddFroze = new System.Windows.Forms.RadioButton();
            this.TrueAddFroze = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ShowHidePassButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdEmplTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CommentFrozeGroupBox.SuspendLayout();
            this.EditFrozeSettingGroupBox.SuspendLayout();
            this.AddFrozeSettingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommentFrozeGroupBox
            // 
            this.CommentFrozeGroupBox.Controls.Add(this.FalseCommentFroze);
            this.CommentFrozeGroupBox.Controls.Add(this.TrueCommentFroze);
            this.CommentFrozeGroupBox.Enabled = false;
            this.CommentFrozeGroupBox.Location = new System.Drawing.Point(197, 321);
            this.CommentFrozeGroupBox.Name = "CommentFrozeGroupBox";
            this.CommentFrozeGroupBox.Size = new System.Drawing.Size(190, 50);
            this.CommentFrozeGroupBox.TabIndex = 75;
            this.CommentFrozeGroupBox.TabStop = false;
            this.CommentFrozeGroupBox.Text = "Комментировать замер";
            // 
            // FalseCommentFroze
            // 
            this.FalseCommentFroze.AutoSize = true;
            this.FalseCommentFroze.Location = new System.Drawing.Point(94, 19);
            this.FalseCommentFroze.Name = "FalseCommentFroze";
            this.FalseCommentFroze.Size = new System.Drawing.Size(83, 17);
            this.FalseCommentFroze.TabIndex = 3;
            this.FalseCommentFroze.TabStop = true;
            this.FalseCommentFroze.Text = "Запрещено";
            this.FalseCommentFroze.UseVisualStyleBackColor = true;
            // 
            // TrueCommentFroze
            // 
            this.TrueCommentFroze.AutoSize = true;
            this.TrueCommentFroze.Location = new System.Drawing.Point(6, 19);
            this.TrueCommentFroze.Name = "TrueCommentFroze";
            this.TrueCommentFroze.Size = new System.Drawing.Size(82, 17);
            this.TrueCommentFroze.TabIndex = 2;
            this.TrueCommentFroze.TabStop = true;
            this.TrueCommentFroze.Text = "Разрешено";
            this.TrueCommentFroze.UseVisualStyleBackColor = true;
            // 
            // EditFrozeSettingGroupBox
            // 
            this.EditFrozeSettingGroupBox.Controls.Add(this.FalseEditFroze);
            this.EditFrozeSettingGroupBox.Controls.Add(this.TrueEditFroze);
            this.EditFrozeSettingGroupBox.Enabled = false;
            this.EditFrozeSettingGroupBox.Location = new System.Drawing.Point(393, 265);
            this.EditFrozeSettingGroupBox.Name = "EditFrozeSettingGroupBox";
            this.EditFrozeSettingGroupBox.Size = new System.Drawing.Size(190, 50);
            this.EditFrozeSettingGroupBox.TabIndex = 74;
            this.EditFrozeSettingGroupBox.TabStop = false;
            this.EditFrozeSettingGroupBox.Text = "Редактировать замер";
            // 
            // FalseEditFroze
            // 
            this.FalseEditFroze.AutoSize = true;
            this.FalseEditFroze.Location = new System.Drawing.Point(95, 20);
            this.FalseEditFroze.Name = "FalseEditFroze";
            this.FalseEditFroze.Size = new System.Drawing.Size(83, 17);
            this.FalseEditFroze.TabIndex = 1;
            this.FalseEditFroze.TabStop = true;
            this.FalseEditFroze.Text = "Запрещено";
            this.FalseEditFroze.UseVisualStyleBackColor = true;
            // 
            // TrueEditFroze
            // 
            this.TrueEditFroze.AutoSize = true;
            this.TrueEditFroze.Location = new System.Drawing.Point(6, 19);
            this.TrueEditFroze.Name = "TrueEditFroze";
            this.TrueEditFroze.Size = new System.Drawing.Size(82, 17);
            this.TrueEditFroze.TabIndex = 0;
            this.TrueEditFroze.TabStop = true;
            this.TrueEditFroze.Text = "Разрешено";
            this.TrueEditFroze.UseVisualStyleBackColor = true;
            // 
            // AddFrozeSettingGroupBox
            // 
            this.AddFrozeSettingGroupBox.Controls.Add(this.FalseAddFroze);
            this.AddFrozeSettingGroupBox.Controls.Add(this.TrueAddFroze);
            this.AddFrozeSettingGroupBox.Enabled = false;
            this.AddFrozeSettingGroupBox.Location = new System.Drawing.Point(197, 265);
            this.AddFrozeSettingGroupBox.Name = "AddFrozeSettingGroupBox";
            this.AddFrozeSettingGroupBox.Size = new System.Drawing.Size(190, 50);
            this.AddFrozeSettingGroupBox.TabIndex = 73;
            this.AddFrozeSettingGroupBox.TabStop = false;
            this.AddFrozeSettingGroupBox.Text = "Добавить замер";
            // 
            // FalseAddFroze
            // 
            this.FalseAddFroze.AutoSize = true;
            this.FalseAddFroze.Location = new System.Drawing.Point(92, 19);
            this.FalseAddFroze.Name = "FalseAddFroze";
            this.FalseAddFroze.Size = new System.Drawing.Size(83, 17);
            this.FalseAddFroze.TabIndex = 1;
            this.FalseAddFroze.Text = "Запрещено";
            this.FalseAddFroze.UseVisualStyleBackColor = true;
            // 
            // TrueAddFroze
            // 
            this.TrueAddFroze.AutoSize = true;
            this.TrueAddFroze.Location = new System.Drawing.Point(4, 19);
            this.TrueAddFroze.Name = "TrueAddFroze";
            this.TrueAddFroze.Size = new System.Drawing.Size(82, 17);
            this.TrueAddFroze.TabIndex = 0;
            this.TrueAddFroze.Text = "Разрешено";
            this.TrueAddFroze.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(72, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Уровень доступа:";
            // 
            // ShowHidePassButton
            // 
            this.ShowHidePassButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowHidePassButton.Image")));
            this.ShowHidePassButton.Location = new System.Drawing.Point(466, 180);
            this.ShowHidePassButton.Name = "ShowHidePassButton";
            this.ShowHidePassButton.Size = new System.Drawing.Size(27, 20);
            this.ShowHidePassButton.TabIndex = 71;
            this.ShowHidePassButton.UseVisualStyleBackColor = true;
            this.ShowHidePassButton.Click += new System.EventHandler(this.ShowHidePassButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(420, 416);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(149, 23);
            this.SaveButton.TabIndex = 70;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(575, 416);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 69;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Enabled = false;
            this.PositionTextBox.Location = new System.Drawing.Point(282, 206);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(179, 20);
            this.PositionTextBox.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(178, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Мой профиль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(294, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Id:";
            // 
            // IdEmplTextBox
            // 
            this.IdEmplTextBox.Enabled = false;
            this.IdEmplTextBox.Location = new System.Drawing.Point(320, 33);
            this.IdEmplTextBox.Name = "IdEmplTextBox";
            this.IdEmplTextBox.Size = new System.Drawing.Size(80, 20);
            this.IdEmplTextBox.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(191, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Должность:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(281, 180);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.PasswordTextBox.TabIndex = 63;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(281, 154);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(179, 20);
            this.UsernameTextBox.TabIndex = 62;
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Location = new System.Drawing.Point(282, 127);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(178, 20);
            this.LastnameTextBox.TabIndex = 61;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(281, 101);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.NameTextBox.TabIndex = 60;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(281, 75);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(180, 20);
            this.SurnameTextBox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(212, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(223, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(231, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Фамилия:";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 451);
            this.Controls.Add(this.CommentFrozeGroupBox);
            this.Controls.Add(this.EditFrozeSettingGroupBox);
            this.Controls.Add(this.AddFrozeSettingGroupBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ShowHidePassButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IdEmplTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(678, 490);
            this.MinimumSize = new System.Drawing.Size(678, 490);
            this.Name = "ProfileForm";
            this.ShowIcon = false;
            this.Text = "Мой профиль";
            this.CommentFrozeGroupBox.ResumeLayout(false);
            this.CommentFrozeGroupBox.PerformLayout();
            this.EditFrozeSettingGroupBox.ResumeLayout(false);
            this.EditFrozeSettingGroupBox.PerformLayout();
            this.AddFrozeSettingGroupBox.ResumeLayout(false);
            this.AddFrozeSettingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox CommentFrozeGroupBox;
        private System.Windows.Forms.RadioButton FalseCommentFroze;
        private System.Windows.Forms.RadioButton TrueCommentFroze;
        private System.Windows.Forms.GroupBox EditFrozeSettingGroupBox;
        private System.Windows.Forms.RadioButton FalseEditFroze;
        private System.Windows.Forms.RadioButton TrueEditFroze;
        private System.Windows.Forms.GroupBox AddFrozeSettingGroupBox;
        private System.Windows.Forms.RadioButton FalseAddFroze;
        private System.Windows.Forms.RadioButton TrueAddFroze;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ShowHidePassButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdEmplTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}