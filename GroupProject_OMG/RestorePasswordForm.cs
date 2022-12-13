using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;
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
    public partial class RestorePasswordForm : Form
    {
        public RestorePasswordForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void buttonRegistrationEnter_Click(object sender, EventArgs e)
        {   
            try
            {

                SmtpClient mySmtpClient = new SmtpClient("smtp.mail.ru");

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = true;
                mySmtpClient.EnableSsl = true;

                System.Net.NetworkCredential basicAuthenticationInfo = new
                System.Net.NetworkCredential("aleksandr.iskusov@mail.ru", "72gfqPQWPEdfduxbB14v");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("aleksandr.iskusov@mail.ru", "ADMIN");
                MailAddress to = new MailAddress($"{textBoxRestore.Text}", "TestToName");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                MailAddress replyTo = new MailAddress("basevitalik@mail.ru");
                myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = "Восстановить пароль";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;


                mySmtpClient.Send(myMail);

                if (true)
                {
                    Console.WriteLine("Почта успешно подтверждена, Введите новый пароль.");
                    Form form = new TestForm(); //форма изменения пароля.
                    form.ShowDialog();
                }
                else
                {
                    Console.WriteLine("Почта не подтверждена!");
                }
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Передвижение окна
        #region
        Point lastPoint;
        private void labelRestore_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelRestore_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelRestore_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelRestore_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        //Кнопка выхода
        #region
        private void pictureBoxCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxCloseWindow_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloseWindow.BackColor = Color.Transparent;
        }

        private void pictureBoxCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }

}
