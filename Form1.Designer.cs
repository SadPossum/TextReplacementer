namespace TextReplacementer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.directoryPathTextBox = new System.Windows.Forms.TextBox();
            this.replsceTextInSubDirectoryLabel = new System.Windows.Forms.Label();
            this.replsceTextInSubDirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceableTextBox = new System.Windows.Forms.TextBox();
            this.replacementTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directoryPathTextBox
            // 
            this.directoryPathTextBox.Location = new System.Drawing.Point(12, 41);
            this.directoryPathTextBox.Name = "directoryPathTextBox";
            this.directoryPathTextBox.Size = new System.Drawing.Size(383, 22);
            this.directoryPathTextBox.TabIndex = 0;
            this.directoryPathTextBox.TextChanged += new System.EventHandler(this.directoryPathTextBox_TextChanged);
            // 
            // replsceTextInSubDirectoryLabel
            // 
            this.replsceTextInSubDirectoryLabel.AutoSize = true;
            this.replsceTextInSubDirectoryLabel.Location = new System.Drawing.Point(12, 66);
            this.replsceTextInSubDirectoryLabel.Name = "replsceTextInSubDirectoryLabel";
            this.replsceTextInSubDirectoryLabel.Size = new System.Drawing.Size(247, 17);
            this.replsceTextInSubDirectoryLabel.TabIndex = 1;
            this.replsceTextInSubDirectoryLabel.Text = "Заменить текст в поддеректориаях:";
            this.replsceTextInSubDirectoryLabel.Visible = false;
            // 
            // replsceTextInSubDirectoryCheckBox
            // 
            this.replsceTextInSubDirectoryCheckBox.AutoSize = true;
            this.replsceTextInSubDirectoryCheckBox.Location = new System.Drawing.Point(265, 67);
            this.replsceTextInSubDirectoryCheckBox.Name = "replsceTextInSubDirectoryCheckBox";
            this.replsceTextInSubDirectoryCheckBox.Size = new System.Drawing.Size(18, 17);
            this.replsceTextInSubDirectoryCheckBox.TabIndex = 2;
            this.replsceTextInSubDirectoryCheckBox.UseVisualStyleBackColor = true;
            this.replsceTextInSubDirectoryCheckBox.Visible = false;
            // 
            // replaceableTextBox
            // 
            this.replaceableTextBox.Location = new System.Drawing.Point(12, 118);
            this.replaceableTextBox.Name = "replaceableTextBox";
            this.replaceableTextBox.Size = new System.Drawing.Size(300, 22);
            this.replaceableTextBox.TabIndex = 3;
            // 
            // replacementTextBox
            // 
            this.replacementTextBox.Location = new System.Drawing.Point(12, 169);
            this.replacementTextBox.Name = "replacementTextBox";
            this.replacementTextBox.Size = new System.Drawing.Size(300, 22);
            this.replacementTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заменить:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Заменить на:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Путь к файлу/директории:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 216);
            this.progressBar.Maximum = 10054;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(457, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 9;
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 196);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(0, 17);
            this.currentFileLabel.TabIndex = 10;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(320, 118);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(149, 73);
            this.replaceButton.TabIndex = 5;
            this.replaceButton.Text = "Заменить";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 251);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replacementTextBox);
            this.Controls.Add(this.replaceableTextBox);
            this.Controls.Add(this.replsceTextInSubDirectoryCheckBox);
            this.Controls.Add(this.replsceTextInSubDirectoryLabel);
            this.Controls.Add(this.directoryPathTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryPathTextBox;
        private System.Windows.Forms.Label replsceTextInSubDirectoryLabel;
        private System.Windows.Forms.CheckBox replsceTextInSubDirectoryCheckBox;
        private System.Windows.Forms.TextBox replaceableTextBox;
        private System.Windows.Forms.TextBox replacementTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Button replaceButton;
    }
}

