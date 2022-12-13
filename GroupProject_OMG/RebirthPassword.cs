using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject_OMG
{
    public partial class RebirthPassword : Form
    {
        public RebirthPassword()
        {
            InitializeComponent();

            #region Button Border
            buttonRebirthEnter.FlatAppearance.BorderSize = 0;
            buttonRebirthEnter.FlatStyle = FlatStyle.Flat;

            #endregion
        }

        private void textBoxPasswordRebirth_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPasswordRebirth.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{8,100}$", RegexOptions.IgnoreCase))
            {
                labelPasswordRebirthScan.Text = "Надежный пароль";
                labelPasswordRebirthScan.ForeColor = Color.Green;
                labelPasswordRebirthScan.Visible = true;
            }
            else
            {
                labelPasswordRebirthScan.Text = "Слабый пароль";
                labelPasswordRebirthScan.ForeColor = Color.Red;
                labelPasswordRebirthScan.Visible = true;
            }
        }

        private void textBoxPasswordRebirthAccess_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordRebirth.Text == textBoxPasswordRebirthAccess.Text && textBoxPasswordRebirth.Text == " ")
            {
                labelPasswordRebirthValid.Text = "Пароли совпадают";
                labelPasswordRebirthValid.ForeColor = Color.Green;
                labelPasswordRebirthValid.Visible = true;
            }
            else
            {
                labelPasswordRebirthValid.Text = "Пароли не совпадают";
                labelPasswordRebirthValid.ForeColor = Color.Red;
                labelPasswordRebirthValid.Visible = true;
            }
        }

        private void RebirthPassword_Load(object sender, EventArgs e)
        {
            labelPasswordRebirthValid.Visible = false;
            labelPasswordRebirthScan.Visible = false;
        }

        //Кнопка закрытия
        #region
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

        //Передвижение окна
        #region
        Point lastPoint;
        private void panelRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panelRegistration_MouseDown(object sender, MouseEventArgs e)
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
