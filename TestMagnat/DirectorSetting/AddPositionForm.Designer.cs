namespace TestMagnat.DirectorSetting
{
    partial class AddPositionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddPosButton = new System.Windows.Forms.Button();
            this.NewNamePositionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Не более 20-ти символов.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите название новой должности:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(121, 90);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPosButton
            // 
            this.AddPosButton.Location = new System.Drawing.Point(40, 90);
            this.AddPosButton.Name = "AddPosButton";
            this.AddPosButton.Size = new System.Drawing.Size(75, 23);
            this.AddPosButton.TabIndex = 6;
            this.AddPosButton.Text = "Добавить";
            this.AddPosButton.UseVisualStyleBackColor = true;
            this.AddPosButton.Click += new System.EventHandler(this.AddPosButton_Click);
            // 
            // NewNamePositionTextBox
            // 
            this.NewNamePositionTextBox.Location = new System.Drawing.Point(40, 37);
            this.NewNamePositionTextBox.Name = "NewNamePositionTextBox";
            this.NewNamePositionTextBox.Size = new System.Drawing.Size(248, 20);
            this.NewNamePositionTextBox.TabIndex = 5;
            // 
            // AddPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddPosButton);
            this.Controls.Add(this.NewNamePositionTextBox);
            this.MinimumSize = new System.Drawing.Size(371, 186);
            this.Name = "AddPositionForm";
            this.ShowIcon = false;
            this.Text = "Добавить позицию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddPosButton;
        private System.Windows.Forms.TextBox NewNamePositionTextBox;
    }
}