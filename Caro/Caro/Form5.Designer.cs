namespace Caro
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.replay_win = new System.Windows.Forms.Button();
            this.exit_win = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Caro.Properties.Resources.win;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.exit_win);
            this.panel1.Controls.Add(this.replay_win);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 575);
            this.panel1.TabIndex = 0;
            // 
            // replay_win
            // 
            this.replay_win.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay_win.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.replay_win.Location = new System.Drawing.Point(104, 420);
            this.replay_win.Name = "replay_win";
            this.replay_win.Size = new System.Drawing.Size(200, 50);
            this.replay_win.TabIndex = 0;
            this.replay_win.Text = "Chơi lại";
            this.replay_win.UseVisualStyleBackColor = true;
            // 
            // exit_win
            // 
            this.exit_win.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_win.ForeColor = System.Drawing.Color.Gold;
            this.exit_win.Location = new System.Drawing.Point(351, 420);
            this.exit_win.Name = "exit_win";
            this.exit_win.Size = new System.Drawing.Size(200, 50);
            this.exit_win.TabIndex = 1;
            this.exit_win.Text = "Thoát";
            this.exit_win.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 577);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_win;
        private System.Windows.Forms.Button replay_win;
    }
}