using conditerskaya;
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

namespace music
{
    public partial class Auth : Form
    {
        database database = new database();
        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            text_login.MaxLength = 50;
            text_password.MaxLength = 50;
        }

        public void F_auth(string login_user, string password_user)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query_string = $"select password, familia from [user] where familia = '{login_user}' and password = '{password_user}'";
            SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход в систему");
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Аккаунт не найден. Зарегистрируйтесь пж");
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            var login_user = text_login.Text;
            var password_user = text_password.Text;
            F_auth(login_user, password_user);
            text_login.Text = "";
            text_password.Text = "";
        }

        private void button_toReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            this.Hide();
            reg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_login_Click(object sender, EventArgs e)
        {
            if (text_login.Text == "Логин")
            {
                text_login.Text = "";
            }
        }

        private void text_password_Click(object sender, EventArgs e)
        {
            if (text_password.Text == "Пароль")
            {
                text_password.Text = "";
                text_password.UseSystemPasswordChar = true;
            }
        }

        private void text_password_Leave(object sender, EventArgs e)
        {
            if (text_password.Text == "")
            {
                text_password.Text = "Пароль";
                text_password.UseSystemPasswordChar = false;
            }
        }

        private void text_login_Leave(object sender, EventArgs e)
        {
            if (text_login.Text == "")
            {
                text_login.Text = "Логин";
            }
        }
    }
}
