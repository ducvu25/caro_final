﻿namespace Caro
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoot = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTA = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBoot);
            this.panel2.Controls.Add(this.btnPlayer);
            this.panel2.Location = new System.Drawing.Point(91, 307);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 135);
            this.panel2.TabIndex = 1;
            // 
            // btnBoot
            // 
            this.btnBoot.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBoot.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoot.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBoot.Location = new System.Drawing.Point(-6, 81);
            this.btnBoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(523, 61);
            this.btnBoot.TabIndex = 1;
            this.btnBoot.Text = "Một người chơi";
            this.btnBoot.UseVisualStyleBackColor = false;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPlayer.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPlayer.Location = new System.Drawing.Point(-6, 0);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(523, 62);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "Hai người chơi";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuLevel});
            this.menuStrip1.Location = new System.Drawing.Point(308, 478);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(111, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // btnMenuLevel
            // 
            this.btnMenuLevel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMenuLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBasic,
            this.btnAdvanced});
            this.btnMenuLevel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLevel.ForeColor = System.Drawing.Color.Gold;
            this.btnMenuLevel.Name = "btnMenuLevel";
            this.btnMenuLevel.Size = new System.Drawing.Size(104, 31);
            this.btnMenuLevel.Text = "Cấp độ";
            this.btnMenuLevel.Click += new System.EventHandler(this.btnMenuLevel_Click);
            // 
            // btnBasic
            // 
            this.btnBasic.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBasic.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(224, 32);
            this.btnBasic.Text = "Dễ";
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdvanced.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(224, 32);
            this.btnAdvanced.Text = "Khó";
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting});
            this.menuStrip3.Location = new System.Drawing.Point(975, 36);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(42, 28);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = global::Caro.Properties.Resources.setting;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAudio,
            this.btnLanguage});
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(35, 24);
            this.btnSetting.Text = "   ";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAudio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.btnAudio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(187, 28);
            this.btnAudio.Text = "Âm thanh";
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTV,
            this.btnTA});
            this.btnLanguage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(187, 28);
            this.btnLanguage.Text = "Ngôn ngữ";
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(189, 28);
            this.btnTV.Text = "Tiếng Việt";
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnTA
            // 
            this.btnTA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTA.Name = "btnTA";
            this.btnTA.Size = new System.Drawing.Size(189, 28);
            this.btnTA.Text = "Tiếng Anh";
            this.btnTA.Click += new System.EventHandler(this.btnTA_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Caro.Properties.Resources.second;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 558);
            this.panel1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1075, 560);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnBoot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuLevel;
        private System.Windows.Forms.ToolStripMenuItem btnBasic;
        private System.Windows.Forms.ToolStripMenuItem btnAdvanced;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem btnSetting;
        private System.Windows.Forms.ToolStripMenuItem btnAudio;
        private System.Windows.Forms.ToolStripMenuItem btnLanguage;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTV;
        private System.Windows.Forms.ToolStripMenuItem btnTA;
    }
}