using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioShop2._0
{
    partial class Shop
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.Button();
            this.korzina = new System.Windows.Forms.Button();
            this.searchGroupe = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SearchLine = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.SortPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toppanel.SuspendLayout();
            this.searchGroupe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.profile);
            this.toppanel.Controls.Add(this.korzina);
            this.toppanel.Controls.Add(this.searchGroupe);
            this.toppanel.Controls.Add(this.logo);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1409, 110);
            this.toppanel.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(1310, 23);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(75, 66);
            this.profile.TabIndex = 3;
            this.profile.Text = "button2";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // korzina
            // 
            this.korzina.Location = new System.Drawing.Point(1211, 23);
            this.korzina.Name = "korzina";
            this.korzina.Size = new System.Drawing.Size(75, 66);
            this.korzina.TabIndex = 2;
            this.korzina.Text = "button1";
            this.korzina.UseVisualStyleBackColor = true;
            // 
            // searchGroupe
            // 
            this.searchGroupe.Controls.Add(this.linkLabel1);
            this.searchGroupe.Controls.Add(this.SearchLine);
            this.searchGroupe.Location = new System.Drawing.Point(219, 13);
            this.searchGroupe.Name = "searchGroupe";
            this.searchGroupe.Size = new System.Drawing.Size(960, 84);
            this.searchGroupe.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(32, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Фильтровать";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // SearchLine
            // 
            this.SearchLine.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLine.Location = new System.Drawing.Point(35, 14);
            this.SearchLine.Name = "SearchLine";
            this.SearchLine.Size = new System.Drawing.Size(888, 26);
            this.SearchLine.TabIndex = 0;
            this.SearchLine.Text = "Найти товар";
            this.SearchLine.Enter += new System.EventHandler(this.SarchLine_Enter);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(187, 85);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // SortPanel
            // 
            this.SortPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SortPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortPanel.Location = new System.Drawing.Point(0, 110);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(200, 625);
            this.SortPanel.TabIndex = 1;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 735);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.toppanel);
            this.Name = "Shop";
            this.Text = "Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Shop_SizeChanged);
            this.toppanel.ResumeLayout(false);
            this.searchGroupe.ResumeLayout(false);
            this.searchGroupe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel toppanel;
        private Button profile;
        private Button korzina;
        private Panel searchGroupe;
        private TextBox SearchLine;
        private PictureBox logo;
        private LinkLabel linkLabel1;
        private FlowLayoutPanel SortPanel;
    }
    #endregion
}