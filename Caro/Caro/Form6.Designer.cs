namespace Caro
{
    partial class Form6
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
            this.replay_lose = new System.Windows.Forms.Button();
            this.exit_lose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // replay_lose
            // 
            this.replay_lose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay_lose.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.replay_lose.Location = new System.Drawing.Point(116, 429);
            this.replay_lose.Name = "replay_lose";
            this.replay_lose.Size = new System.Drawing.Size(207, 54);
            this.replay_lose.TabIndex = 0;
            this.replay_lose.Text = "Chơi lại";
            this.replay_lose.UseVisualStyleBackColor = true;
            // 
            // exit_lose
            // 
            this.exit_lose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lose.ForeColor = System.Drawing.Color.Gold;
            this.exit_lose.Location = new System.Drawing.Point(368, 429);
            this.exit_lose.Name = "exit_lose";
            this.exit_lose.Size = new System.Drawing.Size(207, 54);
            this.exit_lose.TabIndex = 1;
            this.exit_lose.Text = "Thoát";
            this.exit_lose.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caro.Properties.Resources.lose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 568);
            this.Controls.Add(this.exit_lose);
            this.Controls.Add(this.replay_lose);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button replay_lose;
        private System.Windows.Forms.Button exit_lose;
    }
}