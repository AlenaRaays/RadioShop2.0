using System.Windows.Forms;

namespace RadioShop2._0
{
    partial class RegForm
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
            this.LoginB = new System.Windows.Forms.Button();
            this.Fullname = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PasswordRep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.AutoEllipsis = true;
            this.LoginB.BackColor = System.Drawing.Color.White;
            this.LoginB.CausesValidation = false;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginB.Location = new System.Drawing.Point(78, 452);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(222, 36);
            this.LoginB.TabIndex = 0;
            this.LoginB.Text = "Зарегистрироваться";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // Fullname
            // 
            this.Fullname.AcceptsReturn = true;
            this.Fullname.BackColor = System.Drawing.SystemColors.Window;
            this.Fullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fullname.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fullname.Location = new System.Drawing.Point(81, 81);
            this.Fullname.Margin = new System.Windows.Forms.Padding(5);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(219, 24);
            this.Fullname.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.AcceptsReturn = true;
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Font = new System.Drawing.Font("Candara", 14.25F);
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(81, 149);
            this.Login.Margin = new System.Windows.Forms.Padding(5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(219, 24);
            this.Login.TabIndex = 2;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.label11);
            this.Panel.Controls.Add(this.label9);
            this.Panel.Controls.Add(this.PasswordRep);
            this.Panel.Controls.Add(this.label10);
            this.Panel.Controls.Add(this.label8);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.label6);
            this.Panel.Controls.Add(this.PhoneNum);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.Password);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.Login);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.Fullname);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.LoginB);
            this.Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel.Location = new System.Drawing.Point(109, 41);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(385, 524);
            this.Panel.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(81, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Введите номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(81, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Повторите пароль";
            // 
            // PasswordRep
            // 
            this.PasswordRep.AcceptsReturn = true;
            this.PasswordRep.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordRep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordRep.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRep.Location = new System.Drawing.Point(81, 291);
            this.PasswordRep.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordRep.Name = "PasswordRep";
            this.PasswordRep.Size = new System.Drawing.Size(219, 24);
            this.PasswordRep.TabIndex = 12;
            this.PasswordRep.TextChanged += new System.EventHandler(this.PasswordRep_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(72, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 33);
            this.label10.TabIndex = 13;
            this.label10.Text = "________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(81, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Придумайте пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(81, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Придумайте логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(81, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Введите ФИО";
            // 
            // PhoneNum
            // 
            this.PhoneNum.AcceptsReturn = true;
            this.PhoneNum.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNum.Location = new System.Drawing.Point(81, 362);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(5);
            this.PhoneNum.MaxLength = 12;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(219, 24);
            this.PhoneNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(72, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "________________";
            // 
            // Password
            // 
            this.Password.AcceptsReturn = true;
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(81, 222);
            this.Password.Margin = new System.Windows.Forms.Padding(5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(219, 24);
            this.Password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 144);
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
            this.label2.Location = new System.Drawing.Point(72, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "________________";
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackPanel.Location = new System.Drawing.Point(-5, -2);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(596, 616);
            this.BackPanel.TabIndex = 4;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RadioShop2._0.Properties.Resources._34440863_938141074213;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 606);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.BackPanel);
            this.Name = "RegForm";
            this.Text = "RadioShop";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox PhoneNum;
        private Label label5;
        private TextBox Password;
        private Label label4;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox Fullname;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Panel Panel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel BackPanel;
        private Label label11;
        private Label label9;
        private TextBox PasswordRep;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}