namespace GameLess
{
    partial class OptionsForm
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
            this.CloseOptionsButton = new System.Windows.Forms.Button();
            this.TotalHoursAvailableLabel = new System.Windows.Forms.Label();
            this.TotalHoursAvailableValue = new System.Windows.Forms.NumericUpDown();
            this.DesktopNotificationCheckbox = new System.Windows.Forms.CheckBox();
            this.DataFileLocationLabel = new System.Windows.Forms.Label();
            this.DataFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.DataFileLocationBrowseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursAvailableValue)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseOptionsButton
            // 
            this.CloseOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseOptionsButton.Location = new System.Drawing.Point(19, 123);
            this.CloseOptionsButton.Name = "CloseOptionsButton";
            this.CloseOptionsButton.Size = new System.Drawing.Size(105, 44);
            this.CloseOptionsButton.TabIndex = 0;
            this.CloseOptionsButton.Text = "Close";
            this.CloseOptionsButton.UseVisualStyleBackColor = true;
            this.CloseOptionsButton.Click += new System.EventHandler(this.CloseOptionsButton_Click);
            // 
            // TotalHoursAvailableLabel
            // 
            this.TotalHoursAvailableLabel.AutoSize = true;
            this.TotalHoursAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalHoursAvailableLabel.Location = new System.Drawing.Point(13, 13);
            this.TotalHoursAvailableLabel.Name = "TotalHoursAvailableLabel";
            this.TotalHoursAvailableLabel.Size = new System.Drawing.Size(177, 17);
            this.TotalHoursAvailableLabel.TabIndex = 1;
            this.TotalHoursAvailableLabel.Text = "Total hours available daily:";
            // 
            // TotalHoursAvailableValue
            // 
            this.TotalHoursAvailableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalHoursAvailableValue.Location = new System.Drawing.Point(196, 13);
            this.TotalHoursAvailableValue.Name = "TotalHoursAvailableValue";
            this.TotalHoursAvailableValue.Size = new System.Drawing.Size(51, 23);
            this.TotalHoursAvailableValue.TabIndex = 2;
            this.TotalHoursAvailableValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TotalHoursAvailableValue.ValueChanged += new System.EventHandler(this.TotalHoursAvailableValue_ValueChanged);
            // 
            // DesktopNotificationCheckbox
            // 
            this.DesktopNotificationCheckbox.AutoSize = true;
            this.DesktopNotificationCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DesktopNotificationCheckbox.Location = new System.Drawing.Point(16, 46);
            this.DesktopNotificationCheckbox.Name = "DesktopNotificationCheckbox";
            this.DesktopNotificationCheckbox.Size = new System.Drawing.Size(204, 21);
            this.DesktopNotificationCheckbox.TabIndex = 3;
            this.DesktopNotificationCheckbox.Text = "Enable desktop notifications";
            this.DesktopNotificationCheckbox.UseVisualStyleBackColor = true;
            this.DesktopNotificationCheckbox.CheckedChanged += new System.EventHandler(this.DesktopNotificationCheckbox_CheckedChanged);
            // 
            // DataFileLocationLabel
            // 
            this.DataFileLocationLabel.AutoSize = true;
            this.DataFileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DataFileLocationLabel.Location = new System.Drawing.Point(16, 83);
            this.DataFileLocationLabel.Name = "DataFileLocationLabel";
            this.DataFileLocationLabel.Size = new System.Drawing.Size(150, 17);
            this.DataFileLocationLabel.TabIndex = 4;
            this.DataFileLocationLabel.Text = ".CSV data file location:";
            // 
            // DataFileLocationTextBox
            // 
            this.DataFileLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DataFileLocationTextBox.Location = new System.Drawing.Point(170, 80);
            this.DataFileLocationTextBox.Name = "DataFileLocationTextBox";
            this.DataFileLocationTextBox.ReadOnly = true;
            this.DataFileLocationTextBox.Size = new System.Drawing.Size(239, 23);
            this.DataFileLocationTextBox.TabIndex = 5;
            // 
            // DataFileLocationBrowseButton
            // 
            this.DataFileLocationBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DataFileLocationBrowseButton.Location = new System.Drawing.Point(303, 110);
            this.DataFileLocationBrowseButton.Name = "DataFileLocationBrowseButton";
            this.DataFileLocationBrowseButton.Size = new System.Drawing.Size(106, 25);
            this.DataFileLocationBrowseButton.TabIndex = 6;
            this.DataFileLocationBrowseButton.Text = "Browse...";
            this.DataFileLocationBrowseButton.UseVisualStyleBackColor = true;
            this.DataFileLocationBrowseButton.Click += new System.EventHandler(this.DataFileLocationBrowseButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 179);
            this.Controls.Add(this.DataFileLocationBrowseButton);
            this.Controls.Add(this.DataFileLocationTextBox);
            this.Controls.Add(this.DataFileLocationLabel);
            this.Controls.Add(this.DesktopNotificationCheckbox);
            this.Controls.Add(this.TotalHoursAvailableValue);
            this.Controls.Add(this.TotalHoursAvailableLabel);
            this.Controls.Add(this.CloseOptionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.Text = "GameLess Options";
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursAvailableValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseOptionsButton;
        private System.Windows.Forms.Label TotalHoursAvailableLabel;
        private System.Windows.Forms.NumericUpDown TotalHoursAvailableValue;
        private System.Windows.Forms.CheckBox DesktopNotificationCheckbox;
        private System.Windows.Forms.Label DataFileLocationLabel;
        private System.Windows.Forms.TextBox DataFileLocationTextBox;
        private System.Windows.Forms.Button DataFileLocationBrowseButton;
    }
}