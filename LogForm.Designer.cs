using System.Drawing;
using System.Windows.Forms;

namespace RadioShop2._0
{
    partial class LogForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginB = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textpasswordvis = new System.Windows.Forms.Label();
            this.textloginvis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.AutoEllipsis = true;
            this.LoginB.BackColor = System.Drawing.Color.White;
            this.LoginB.CausesValidation = false;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginB.Location = new System.Drawing.Point(80, 299);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(231, 36);
            this.LoginB.TabIndex = 0;
            this.LoginB.Text = "Войти";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // Login
            // 
            this.Login.AcceptsReturn = true;
            this.Login.BackColor = System.Drawing.SystemColors.Window;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(83, 122);
            this.Login.Margin = new System.Windows.Forms.Padding(5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(217, 24);
            this.Login.TabIndex = 1;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Password
            // 
            this.Password.AcceptsReturn = true;
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(83, 201);
            this.Password.Margin = new System.Windows.Forms.Padding(5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(217, 19);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.linkLabel1);
            this.Panel.Controls.Add(this.textpasswordvis);
            this.Panel.Controls.Add(this.textloginvis);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.Password);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.Login);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.LoginB);
            this.Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel.Location = new System.Drawing.Point(106, 113);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(385, 395);
            this.Panel.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(134, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Зарегестрироваться";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textpasswordvis
            // 
            this.textpasswordvis.AutoSize = true;
            this.textpasswordvis.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpasswordvis.ForeColor = System.Drawing.Color.DarkGray;
            this.textpasswordvis.Location = new System.Drawing.Point(77, 225);
            this.textpasswordvis.Name = "textpasswordvis";
            this.textpasswordvis.Size = new System.Drawing.Size(98, 15);
            this.textpasswordvis.TabIndex = 6;
            this.textpasswordvis.Text = "Введите пароль";
            // 
            // textloginvis
            // 
            this.textloginvis.AutoSize = true;
            this.textloginvis.BackColor = System.Drawing.Color.Transparent;
            this.textloginvis.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textloginvis.ForeColor = System.Drawing.Color.DarkGray;
            this.textloginvis.Location = new System.Drawing.Point(77, 151);
            this.textloginvis.Name = "textloginvis";
            this.textloginvis.Size = new System.Drawing.Size(91, 15);
            this.textloginvis.TabIndex = 5;
            this.textloginvis.Text = "Введите логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Авторизация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "________________";
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackPanel.Controls.Add(this.Panel);
            this.BackPanel.Location = new System.Drawing.Point(-5, -2);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(596, 616);
            this.BackPanel.TabIndex = 4;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RadioShop2._0.Properties.Resources._34440863_938141074213;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 606);
            this.Controls.Add(this.BackPanel);
            this.MaximumSize = new System.Drawing.Size(600, 645);
            this.MinimumSize = new System.Drawing.Size(600, 645);
            this.Name = "LogForm";
            this.Text = "RadioShop";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Panel Panel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel BackPanel;
        private Label textpasswordvis;
        private Label textloginvis;
        private LinkLabel linkLabel1;
    }
}

