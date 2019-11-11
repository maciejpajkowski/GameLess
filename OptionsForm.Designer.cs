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
            this.SuspendLayout();
            // 
            // CloseOptionsButton
            // 
            this.CloseOptionsButton.Location = new System.Drawing.Point(12, 120);
            this.CloseOptionsButton.Name = "CloseOptionsButton";
            this.CloseOptionsButton.Size = new System.Drawing.Size(105, 44);
            this.CloseOptionsButton.TabIndex = 0;
            this.CloseOptionsButton.Text = "Close";
            this.CloseOptionsButton.UseVisualStyleBackColor = true;
            this.CloseOptionsButton.Click += new System.EventHandler(this.CloseOptionsButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 179);
            this.Controls.Add(this.CloseOptionsButton);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseOptionsButton;
    }
}