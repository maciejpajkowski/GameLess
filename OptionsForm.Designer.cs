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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursAvailableValue)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseOptionsButton
            // 
            this.CloseOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseOptionsButton.Location = new System.Drawing.Point(142, 123);
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
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(16, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Desktop notification on time\'s up";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 179);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TotalHoursAvailableValue);
            this.Controls.Add(this.TotalHoursAvailableLabel);
            this.Controls.Add(this.CloseOptionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursAvailableValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseOptionsButton;
        private System.Windows.Forms.Label TotalHoursAvailableLabel;
        private System.Windows.Forms.NumericUpDown TotalHoursAvailableValue;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}