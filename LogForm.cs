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
    public partial class LogForm : Form
    {
        public static SqlDataAdapter adapter;
        public static DataSet data = new DataSet();


        public LogForm()
        {
            InitializeComponent();

            

            //незабывай писать Initial Catalog в строке подключения!
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Integrated Security=True" +
                ";Pooling=False;MultipleActiveResultSets=False;TrustServerCertificate=True;" +
                "Application Name=\"SQL Server Management Studio\"; Initial Catalog=RadioShop;";
                SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string selectQuery = "SELECT * FROM dbo.Client;";
                    adapter = new SqlDataAdapter(selectQuery, connectionString);

                    adapter.Fill(data);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in data.Tables[0].Rows)
            {
                try
                {
                    if (row["login"].ToString() == Login.Text && row["password"].ToString() == Password.Text)
                    {
                        MessageBox.Show("Регистрация прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;

                        Shop shop = new Shop();
                        shop.Show();

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.Text))
            {
                textloginvis.Text = "Логин топ";
            }
            else
            {
                textloginvis.Text = "Введите логин";
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Password.Text))
            {
                textpasswordvis.Text = "Пароль тоже топ. Хотя я его не видел";
            }
            else
            {
                textpasswordvis.Text = "Введите пароль";
            }
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }
    }
}
