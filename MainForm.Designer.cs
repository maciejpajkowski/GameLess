namespace GameLess
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CurrentSessionLabel = new System.Windows.Forms.Label();
            this.CurrentSessionTimer = new System.Windows.Forms.Label();
            this.CurrentSessionProgressBar = new System.Windows.Forms.ProgressBar();
            this.GameButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.FormTimer = new System.Windows.Forms.Timer(this.components);
            this.StatsButton = new System.Windows.Forms.Button();
            this.SystemTrayNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // CurrentSessionLabel
            // 
            this.CurrentSessionLabel.AutoSize = true;
            this.CurrentSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentSessionLabel.Location = new System.Drawing.Point(25, 26);
            this.CurrentSessionLabel.Name = "CurrentSessionLabel";
            this.CurrentSessionLabel.Size = new System.Drawing.Size(124, 20);
            this.CurrentSessionLabel.TabIndex = 0;
            this.CurrentSessionLabel.Text = "Current session:";
            // 
            // CurrentSessionTimer
            // 
            this.CurrentSessionTimer.AutoSize = true;
            this.CurrentSessionTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentSessionTimer.ForeColor = System.Drawing.Color.Black;
            this.CurrentSessionTimer.Location = new System.Drawing.Point(243, 22);
            this.CurrentSessionTimer.Name = "CurrentSessionTimer";
            this.CurrentSessionTimer.Size = new System.Drawing.Size(288, 25);
            this.CurrentSessionTimer.TabIndex = 0;
            this.CurrentSessionTimer.Text = "0 hours 0 minutes 0 seconds";
            // 
            // CurrentSessionProgressBar
            // 
            this.CurrentSessionProgressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CurrentSessionProgressBar.Location = new System.Drawing.Point(29, 62);
            this.CurrentSessionProgressBar.Name = "CurrentSessionProgressBar";
            this.CurrentSessionProgressBar.Size = new System.Drawing.Size(502, 33);
            this.CurrentSessionProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CurrentSessionProgressBar.TabIndex = 1;
            // 
            // GameButton
            // 
            this.GameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameButton.Location = new System.Drawing.Point(29, 133);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(136, 69);
            this.GameButton.TabIndex = 2;
            this.GameButton.Text = "Play!";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OptionsButton.Location = new System.Drawing.Point(186, 146);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(103, 45);
            this.OptionsButton.TabIndex = 2;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuitButton.Location = new System.Drawing.Point(428, 146);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(103, 45);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FormTimer
            // 
            this.FormTimer.Interval = 1000;
            this.FormTimer.Tick += new System.EventHandler(this.OnUpdateTimerTick);
            // 
            // StatsButton
            // 
            this.StatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatsButton.Location = new System.Drawing.Point(308, 146);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(103, 45);
            this.StatsButton.TabIndex = 2;
            this.StatsButton.Text = "Stats";
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // SystemTrayNotification
            // 
            this.SystemTrayNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayNotification.Icon")));
            this.SystemTrayNotification.Text = "GameLess";
            this.SystemTrayNotification.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 214);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.CurrentSessionProgressBar);
            this.Controls.Add(this.CurrentSessionTimer);
            this.Controls.Add(this.CurrentSessionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GameLess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentSessionLabel;
        private System.Windows.Forms.Label CurrentSessionTimer;
        private System.Windows.Forms.ProgressBar CurrentSessionProgressBar;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Timer FormTimer;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.NotifyIcon SystemTrayNotification;
    }
}

