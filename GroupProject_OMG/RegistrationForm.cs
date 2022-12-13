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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace GroupProject_OMG
{
    public partial class RegistrationForm : Form
    {
        private string text;

        public RegistrationForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            pictureBoxCapcha.Image = this.CreateImage(pictureBoxCapcha.Width, pictureBoxCapcha.Height);

            textBoxNameReg.Text = "Введите Ваше имя";
            textBoxNameReg.ForeColor = Color.BlueViolet;

            textBoxLoginReg.Text = "Придумайте логин";
            textBoxLoginReg.ForeColor = Color.BlueViolet;

            textBoxEmailReg.Text = "Email";
            textBoxEmailReg.ForeColor = Color.BlueViolet;

            textBoxPasswordReg.Text = "Придумайте пароль";
            textBoxPasswordReg.ForeColor = Color.BlueViolet;

            textBoxPasswordRescanReg.Text = "Повторите пароль";
            textBoxPasswordRescanReg.ForeColor = Color.BlueViolet;

            textBoxCapcha.Text = "Введите капчу";
            textBoxCapcha.ForeColor = Color.BlueViolet;

            #region Button Border
            buttonUpdateCapcha.FlatAppearance.BorderSize = 0;
            buttonUpdateCapcha.FlatStyle = FlatStyle.Flat;

            buttonRegistrationEnter.FlatAppearance.BorderSize = 0;
            buttonRegistrationEnter.FlatStyle = FlatStyle.Flat;
            #endregion
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        }

        #region Bitmap
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = 10;
            int Ypos = 10;

            //Добавим различные цвета ддя текста
            Brush[] colors = {
            Brushes.Black,
            Brushes.Red,
            Brushes.RoyalBlue,
            Brushes.Green,
            Brushes.Yellow,
            Brushes.White,
            Brushes.Tomato,
            Brushes.Sienna,
            Brushes.Pink };

            //Добавим различные цвета линий
            Pen[] colorpens = {
            Pens.Black,
            Pens.Red,
            Pens.RoyalBlue,
            Pens.Green,
            Pens.Yellow,
            Pens.White,
            Pens.Tomato,
            Pens.Sienna,
            Pens.Pink };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = {
            FontStyle.Bold,
            FontStyle.Italic,
            FontStyle.Regular,
            FontStyle.Strikeout,
            FontStyle.Underline};

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text = String.Empty;
            string ALF = "7890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
            new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, Height - 1),
            new Point(Width - 1, 0));

            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
        #endregion

        #region Capcha
        //private void buttonOkCapcha_Click(object sender, EventArgs e)
        //{
        //    {
        //        if (textBoxCapcha.Text == this.text)
        //            MessageBox.Show("Верно!");
        //        else
        //            MessageBox.Show("Ошибка!");
        //    }
        //}

        private void buttonUpdateCapcha_Click(object sender, EventArgs e)
        {
            pictureBoxCapcha.Image = this.CreateImage(pictureBoxCapcha.Width, pictureBoxCapcha.Height);
        }
        #endregion
        
        #region Подсказки в textbox
        
        private void textBoxLoginReg_Enter(object sender, EventArgs e)
        {
            if (textBoxLoginReg.Text == "Придумайте логин")
            {
                textBoxLoginReg.Text = "";

                textBoxLoginReg.ForeColor = Color.Black;
            }
        }

        private void textBoxLoginReg_Leave(object sender, EventArgs e)
        {
            if (textBoxLoginReg.Text == "")
            {
                textBoxLoginReg.Text = "Придумайте логин";

                textBoxLoginReg.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxNameReg_Enter(object sender, EventArgs e)
        {
            if (textBoxNameReg.Text == "Введите Ваше имя")
            {
                textBoxNameReg.Text = "";

                textBoxNameReg.ForeColor = Color.Black;
            }
        }

        private void textBoxNameReg_Leave(object sender, EventArgs e)
        {
            if (textBoxNameReg.Text == "")
            {
                textBoxNameReg.Text = "Введите Ваше имя";

                textBoxNameReg.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxEmailReg_Enter(object sender, EventArgs e)
        {
            if (textBoxEmailReg.Text == "Email")
            {
                textBoxEmailReg.Text = "";

                textBoxEmailReg.ForeColor = Color.Black;
            }
        }

        private void textBoxEmailReg_Leave(object sender, EventArgs e)
        {
            if (textBoxEmailReg.Text == "")
            {
                textBoxEmailReg.Text = "Email";

                textBoxEmailReg.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxPasswordReg_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordReg.Text == "Придумайте пароль")
            {
                textBoxPasswordReg.Text = "";

                textBoxPasswordReg.ForeColor = Color.Black;
            }

        }

        private void textBoxPasswordReg_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordReg.Text == "")
            {
                textBoxPasswordReg.Text = "Придумайте пароль";

                textBoxPasswordReg.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxPasswordRescanReg_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordRescanReg.Text == "Повторите пароль")
            {
                textBoxPasswordRescanReg.Text = "";

                textBoxPasswordRescanReg.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordRescanReg_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordRescanReg.Text == "")
            {
                textBoxPasswordRescanReg.Text = "Повторите пароль";

                textBoxPasswordRescanReg.ForeColor = Color.BlueViolet;
            }
        }

        private void textBoxCapcha_Enter(object sender, EventArgs e)
        {
            if (textBoxCapcha.Text == "Введите капчу")
            {
                textBoxCapcha.Text = "";

                textBoxCapcha.ForeColor = Color.Black;
            }
        }

        private void textBoxCapcha_Leave(object sender, EventArgs e)
        {
            if (textBoxCapcha.Text == "")
            {
                textBoxCapcha.Text = "Введите капчу";

                textBoxCapcha.ForeColor = Color.BlueViolet;
            }
        }
        #endregion
        
        #region Проверка пароля
        private void textBoxPasswordReg_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPasswordReg.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{8,100}$", RegexOptions.IgnoreCase))
            {
                labelPasswordRegScan.Text = "Надежный пароль";
                labelPasswordRegScan.ForeColor = Color.Green;
                labelPasswordRegScan.Visible = true;
            }
            else
            {
                labelPasswordRegScan.Text = "Слабый пароль";
                labelPasswordRegScan.ForeColor = Color.Red;
                labelPasswordRegScan.Visible = true;
            }
        }
        private void textBoxPasswordRescanReg_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordReg.Text == textBoxPasswordRescanReg.Text && textBoxPasswordReg.Text == " ")
            {
                labelPasswordAllValid.Text = "Пароли совпадают";
                labelPasswordAllValid.ForeColor = Color.Green;
                labelPasswordAllValid.Visible = true;
            }
            else
            {
                labelPasswordAllValid.Text = "Пароли не совпадают";
                labelPasswordAllValid.ForeColor = Color.Red;
                labelPasswordAllValid.Visible = true;
            }
        }
        #endregion

        private void buttonRegistrationEnter_Click(object sender, EventArgs e)
        {
            try
            {
                //проверка имени
                if (textBoxNameReg.TextLength > 25)
                        MessageBox.Show("Превышенно количество символов");
                //Проверка почты
                else if(Regex.IsMatch(textBoxEmailReg.Text, @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,100}$"))
                        throw new Exception();
                //Проверка логина
                else if(Regex.IsMatch(textBoxPasswordReg.Text, @"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{8,15}$"))
                        throw new Exception();
                //Проверка пароля
                else if(Regex.IsMatch(textBoxPasswordReg.Text, @"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{8,31}$"))
                        throw new Exception();
                //Заполненные поля
                else if(textBoxLoginReg.Text == " " || textBoxLoginReg.Text == "Придумайте логин")
                {
                    MessageBox.Show("Ошибка, ПОЛЕ логин НЕ ЗАПОЛНЕНО!");
                }
                else if (textBoxNameReg.Text == " " || textBoxNameReg.Text == "Введите Ваше имя")
                {
                    MessageBox.Show("Ошибка, ПОЛЕ имя НЕ ЗАПОЛНЕНО!");
                }
                else if (textBoxPasswordReg.Text == " " || textBoxPasswordReg.Text == "Придумайте пароль")
                {
                    MessageBox.Show("Ошибка, ПОЛЕ пароль НЕ ЗАПОЛНЕНО!");
                }
                else if (textBoxPasswordRescanReg.Text == " " || textBoxPasswordRescanReg.Text == "Повторите пароль")
                {
                    MessageBox.Show("Ошибка, ПОЛЕ повторения пароля НЕ ЗАПОЛНЕНО!");
                }
                //Проверка капчи
                else if (textBoxCapcha.Text != this.text)
                {
                    MessageBox.Show("Неверная капча");
                }
                else
                {
                    DB dB = new DB();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `number`, `email`, `role`) VALUES (@login,@pass,@name, @number,@email, 0)", dB.GetConnection());
                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLoginReg.Text;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPasswordReg.Text;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxNameReg.Text;
                    command.Parameters.Add("@number", MySqlDbType.VarChar).Value = maskedTextBoxNumberReg.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmailReg.Text;
                    dB.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Аккаунт был создан");
                    else
                        MessageBox.Show("Аккаунт не был создан");
                    dB.closeConnection();

                    Form mainForm = new MainForm();
                    mainForm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка" + ex.ToString());
            }
        }
        
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            labelPasswordRegScan.Visible = false;
            labelPasswordAllValid.Visible = false;
        }

        #region Кнопка выхода
        private void pictureBoxCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.WhiteSmoke;
        }
        private void pictureBoxCloseWindow_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.Transparent;
        }
        private void pictureBoxCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Передвижение окна
        Point lastPoint;
        private void panelRegistration_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelRegistration_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void panelRegistration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginReg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
