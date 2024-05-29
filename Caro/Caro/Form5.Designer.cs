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
            this.f5lbMess = new System.Windows.Forms.Label();
            this.f5btnThoat = new System.Windows.Forms.Button();
            this.f5btnChoiLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Caro.Properties.Resources.win;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.f5lbMess);
            this.panel1.Controls.Add(this.f5btnThoat);
            this.panel1.Controls.Add(this.f5btnChoiLai);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 467);
            this.panel1.TabIndex = 0;
            // 
            // f5lbMess
            // 
            this.f5lbMess.AutoSize = true;
            this.f5lbMess.BackColor = System.Drawing.Color.Transparent;
            this.f5lbMess.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5lbMess.Location = new System.Drawing.Point(390, 166);
            this.f5lbMess.Name = "f5lbMess";
            this.f5lbMess.Size = new System.Drawing.Size(65, 24);
            this.f5lbMess.TabIndex = 3;
            this.f5lbMess.Text = "label1";
            // 
            // f5btnThoat
            // 
            this.f5btnThoat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5btnThoat.ForeColor = System.Drawing.Color.Gold;
            this.f5btnThoat.Location = new System.Drawing.Point(263, 341);
            this.f5btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.f5btnThoat.Name = "f5btnThoat";
            this.f5btnThoat.Size = new System.Drawing.Size(150, 41);
            this.f5btnThoat.TabIndex = 1;
            this.f5btnThoat.Text = "Thoát";
            this.f5btnThoat.UseVisualStyleBackColor = true;
            this.f5btnThoat.Click += new System.EventHandler(this.f5btnThoat_Click);
            // 
            // f5btnChoiLai
            // 
            this.f5btnChoiLai.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5btnChoiLai.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.f5btnChoiLai.Location = new System.Drawing.Point(78, 341);
            this.f5btnChoiLai.Margin = new System.Windows.Forms.Padding(2);
            this.f5btnChoiLai.Name = "f5btnChoiLai";
            this.f5btnChoiLai.Size = new System.Drawing.Size(150, 41);
            this.f5btnChoiLai.TabIndex = 0;
            this.f5btnChoiLai.Text = "Chơi lại";
            this.f5btnChoiLai.UseVisualStyleBackColor = true;
            this.f5btnChoiLai.Click += new System.EventHandler(this.f5btnChoiLai_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 469);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button f5btnThoat;
        private System.Windows.Forms.Button f5btnChoiLai;
        private System.Windows.Forms.Label f5lbMess;
    }
}