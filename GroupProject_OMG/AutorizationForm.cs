using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GroupProject_OMG
{
    public partial class AutorizationForm : Form
    {

        public AutorizationForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            /*
            textBoxLoginNickName.Text = "Логин";
            textBoxLoginNickName.ForeColor = Color.BlueViolet;
            */
            #region Button Border
            buttonAuthorizationEnter.FlatAppearance.BorderSize = 0;
            buttonAuthorizationEnter.FlatStyle = FlatStyle.Flat;

            buttonForgotPassword.FlatAppearance.BorderSize = 0;
            buttonForgotPassword.FlatStyle = FlatStyle.Flat;

            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            #endregion
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {

        }
        private void textBoxLoginNickName_Enter(object sender, EventArgs e)
        {
            /*
            if (textBoxLoginNickName.Text == "Логин")
            {
                textBoxLoginNickName.Text = "";

                textBoxLoginNickName.ForeColor = Color.Black;
            }*/
        }

        private void textBoxLoginNickName_Leave(object sender, EventArgs e)
        {/*
            if (textBoxLoginNickName.Text == "")
            {
                textBoxLoginNickName.Text = "Логин";

                textBoxLoginNickName.ForeColor = Color.BlueViolet;
            }*/
        }

        private void buttonAuthorizationEnter_Click(object sender, EventArgs e)
        {

            String loginUSer = textBoxLoginNickName.Text;
            String passUser = textBoxPasswordLogin.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            //позволяет выбрать объекты из бд
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Объект позволяющий прописать команду на выборку данных из БД
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUSer;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
                MessageBox.Show("Dobro Pozalovat " + textBoxLoginNickName.Text);
                Form form = new Administration();
                form.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Такого пользователя не существует!");
            }

        }  
        #region Кнопка закрытия
        private void pictureBoxCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBoxCloseWindow_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.Transparent;
        }

        private void pictureBoxCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.WhiteSmoke;

        }

        #endregion

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            Form form = new RebirthPassword();
            form.Show();
            this.Close();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Form form = new RegistrationForm();
            form.Show();
        }

    }
}
