namespace DDD.WinForm.Views
{
    partial class WeatherSaveView
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AreIdComboBox = new System.Windows.Forms.ComboBox();
            this.ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimeComboBox = new System.Windows.Forms.DateTimePicker();
            this.TempartureTextBox = new System.Windows.Forms.TextBox();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(47, 23);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(168, 46);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "地域";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "日付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "状態";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "温度";
            // 
            // AreIdComboBox
            // 
            this.AreIdComboBox.FormattingEnabled = true;
            this.AreIdComboBox.Location = new System.Drawing.Point(169, 85);
            this.AreIdComboBox.Name = "AreIdComboBox";
            this.AreIdComboBox.Size = new System.Drawing.Size(251, 35);
            this.AreIdComboBox.TabIndex = 5;
            // 
            // ConditionComboBox
            // 
            this.ConditionComboBox.FormattingEnabled = true;
            this.ConditionComboBox.Location = new System.Drawing.Point(169, 264);
            this.ConditionComboBox.Name = "ConditionComboBox";
            this.ConditionComboBox.Size = new System.Drawing.Size(251, 35);
            this.ConditionComboBox.TabIndex = 6;
            // 
            // DateTimeComboBox
            // 
            this.DateTimeComboBox.Location = new System.Drawing.Point(169, 174);
            this.DateTimeComboBox.Name = "DateTimeComboBox";
            this.DateTimeComboBox.Size = new System.Drawing.Size(244, 34);
            this.DateTimeComboBox.TabIndex = 7;
            // 
            // TempartureTextBox
            // 
            this.TempartureTextBox.Location = new System.Drawing.Point(169, 343);
            this.TempartureTextBox.Name = "TempartureTextBox";
            this.TempartureTextBox.Size = new System.Drawing.Size(245, 34);
            this.TempartureTextBox.TabIndex = 8;
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(447, 343);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(36, 27);
            this.UnitLabel.TabIndex = 9;
            this.UnitLabel.Text = "xx";
            // 
            // WeatherSaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.TempartureTextBox);
            this.Controls.Add(this.DateTimeComboBox);
            this.Controls.Add(this.ConditionComboBox);
            this.Controls.Add(this.AreIdComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "WeatherSaveView";
            this.Text = "WeatherSaveView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AreIdComboBox;
        private System.Windows.Forms.ComboBox ConditionComboBox;
        private System.Windows.Forms.DateTimePicker DateTimeComboBox;
        private System.Windows.Forms.TextBox TempartureTextBox;
        private System.Windows.Forms.Label UnitLabel;
    }
}