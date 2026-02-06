using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioShop2._0
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            FormClosed += RegForm_FormClosed;
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Fullname.Text) && string.IsNullOrWhiteSpace(Fullname.Text))
            {
                MessageBox.Show("ФИО не может быть пустым!","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Login.Text) && string.IsNullOrWhiteSpace(Login.Text))
            {
                MessageBox.Show("Логин не может быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Password.Text) && string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Пароль не может быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(PasswordRep.Text) && string.IsNullOrWhiteSpace(PasswordRep.Text))
            {
                MessageBox.Show("Поторите пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(PhoneNum.Text) && string.IsNullOrWhiteSpace(PhoneNum.Text))
            {
                MessageBox.Show("Телефон не может быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataRow NewRow = LogForm.data.Tables[0].NewRow();

                NewRow["fullname"] = Fullname.Text;
                NewRow["login"] = Login.Text;
                NewRow["password"] = Password.Text;
                NewRow["phonenumber"] = PhoneNum.Text;
                NewRow["clientTypeID"] = 1;

                LogForm.data.Tables[0].Rows.Add(NewRow);
                SaveData();

                Hide();
                LogForm log = new LogForm();
                log.ShowDialog();            
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            foreach(DataRow row in LogForm.data.Tables[0].Rows)
            {
                if (Login.Text == row["login"].ToString())
                {
                    label7.Text = "Такой пользователь уже существует";
                    label7.ForeColor = Color.LightPink;
                }
                else
                {
                    label7.Text = "Придумайте логин";
                    label7.ForeColor = Color.DarkGray;
                }
            }
        }

        private void PasswordRep_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != PasswordRep.Text && !string.IsNullOrEmpty(Password.Text) 
                && !string.IsNullOrWhiteSpace(Password.Text) && !string.IsNullOrWhiteSpace(PasswordRep.Text))
            {
                label9.Text = "Пароли не совпадают";
                label9.ForeColor = Color.LightPink;
            }
            else if (Password.Text == PasswordRep.Text && !string.IsNullOrEmpty(Password.Text)
                && !string.IsNullOrWhiteSpace(Password.Text) && !string.IsNullOrWhiteSpace(PasswordRep.Text))
            {
                label9.Text = "Так лучше)";
                label9.ForeColor = Color.LightGreen;
            }
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(LogForm.adapter);
            LogForm.adapter.Update(LogForm.data);
        }
    }
}
