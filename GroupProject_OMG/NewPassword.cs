using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject_OMG
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();

            #region Подсказки в TextBox
            textBoxCode.Text = "Введите код из смс с email";
            textBoxCode.ForeColor = Color.BlueViolet;

            textBoxNewPass1.Text = "Введите новый пароль";
            textBoxNewPass1.ForeColor = Color.BlueViolet;

            textBoxNewPass2.Text = "Повторите новый пароль";
            textBoxNewPass2.ForeColor = Color.BlueViolet;
            #endregion
        }
        private void NewPassword_Load(object sender, EventArgs e)
        {

        }

        #region Подсказкив TextBox
        private void textBoxCode_Enter(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "Введите код из смс с email")
            {
                textBoxCode.Text = "";

                textBoxCode.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxCode_Leave(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {
                textBoxCode.Text = "Введите код из смс с email";

                textBoxCode.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxNewPass1_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPass1.Text == "Введите новый пароль")
            {
                textBoxNewPass1.Text = "";

                textBoxNewPass1.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxNewPass1_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPass1.Text == "")
            {
                textBoxNewPass1.Text = "Введите новый пароль";

                textBoxNewPass1.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxNewPass2_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPass2.Text == "Повторите новый пароль")
            {
                textBoxNewPass2.Text = "";

                textBoxNewPass2.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxNewPass2_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPass2.Text == "")
            {
                textBoxNewPass2.Text = "Повторите новый пароль";

                textBoxNewPass2.ForeColor = Color.BlueViolet;
            }
        }
        #endregion

        #region Кнопка выхода
        private void pictureBoxCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxCloseWindow_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.Transparent;
        }

        #endregion
        #region Передвежение окна
        Point lastPoint;
        private void panelEditPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelEditPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelRebirth_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelRebirth_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion
    }

}