using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Net;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using MySql.Data.MySqlClient;

namespace GroupProject_OMG
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            #region Button Border
            buttonDeleteFromLocal.FlatAppearance.BorderSize = 0;
            buttonDeleteFromLocal.FlatStyle = FlatStyle.Flat;

            buttonLoadFileOnCloud.FlatAppearance.BorderSize = 0;
            buttonLoadFileOnCloud.FlatStyle = FlatStyle.Flat;

            buttonLoadFileOnLocal.FlatAppearance.BorderSize = 0;
            buttonLoadFileOnLocal.FlatStyle = FlatStyle.Flat;

            buttonLoadFolderOnCloud.FlatAppearance.BorderSize = 0;
            buttonLoadFolderOnCloud.FlatStyle = FlatStyle.Flat;

            buttonLoadFolderOnLocal.FlatAppearance.BorderSize = 0;
            buttonLoadFolderOnLocal.FlatStyle = FlatStyle.Flat;

            buttonSync.FlatAppearance.BorderSize = 0;
            buttonSync.FlatStyle = FlatStyle.Flat;

            buttonDeleteFromCloud.FlatAppearance.BorderSize = 0;
            buttonDeleteFromCloud.FlatStyle = FlatStyle.Flat;

            #endregion
        }

        //private string folderPathName;
        private void textBoxFolderPathSave_MouseClick(object sender, MouseEventArgs e)
        {
            #region off cursor
            this.ActiveControl = null;
            #endregion
            #region path of save
            // показать диалог выбора папки
            DialogResult result = folderBrowserDialogPath.ShowDialog();
            // если папка выбрана и нажата клавиша `OK` - значит можно получить путь к папке
            if (result == DialogResult.OK)
            {
                // запишем в нашу переменную путь к папке
                //folderPathName = folderBrowserDialog1.SelectedPath;
                //запускаю файл
                //Process.Start(openFileDialog1.FileName);
                textBoxFolderPathSave.Text = folderBrowserDialogPath.SelectedPath;
            }
            #endregion  
        }

        private void listViewCloud_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void getFtpFileList()
        {
            /*
            List<string> files = new List<string>();

            try
            {
                FtpWebRequest request = FtpWebRequest.Create("ftp://" + txtHost.Text) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    files.Add(reader.ReadLine());
                }
                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                }
                reader.Close();
                responseStream.Close();
                response.Close();
            }

            catch (Exception ex)
            {

            }*/
        }
    }
}
