namespace TestMagnat.Froze
{
    partial class ChooseGagerForm
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
            this.ChooseGagerButton = new System.Windows.Forms.Button();
            this.GagerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ChooseGagerButton
            // 
            this.ChooseGagerButton.Location = new System.Drawing.Point(264, 210);
            this.ChooseGagerButton.Name = "ChooseGagerButton";
            this.ChooseGagerButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseGagerButton.TabIndex = 3;
            this.ChooseGagerButton.Text = "Выбрать";
            this.ChooseGagerButton.UseVisualStyleBackColor = true;
            this.ChooseGagerButton.Click += new System.EventHandler(this.ChooseGagerButton_Click);
            // 
            // GagerListBox
            // 
            this.GagerListBox.FormattingEnabled = true;
            this.GagerListBox.Location = new System.Drawing.Point(12, 12);
            this.GagerListBox.Name = "GagerListBox";
            this.GagerListBox.Size = new System.Drawing.Size(241, 225);
            this.GagerListBox.TabIndex = 2;
            this.GagerListBox.DoubleClick += new System.EventHandler(this.GagerListBox_DoubleClick);
            // 
            // ChooseGagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 256);
            this.Controls.Add(this.ChooseGagerButton);
            this.Controls.Add(this.GagerListBox);
            this.MinimumSize = new System.Drawing.Size(369, 295);
            this.Name = "ChooseGagerForm";
            this.ShowIcon = false;
            this.Text = "Выбор монтажника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseGagerButton;
        private System.Windows.Forms.ListBox GagerListBox;
    }
}