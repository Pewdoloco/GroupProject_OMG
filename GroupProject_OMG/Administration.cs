using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace GroupProject_OMG
{
    public partial class Administration : Form
    {
        //MySqlConnection connection_admin = new MySqlConnection(server=ftp.a0742318.xsph.ru;username=a0742318;password=fWLSDDfuic;database=a0742318_authorization_users;CharacterSet = utf8; AllowPublicKeyRetrieval=True);

        MySqlCommand cmd;
        int id;  
        MySqlConnectionStringBuilder str_connect = new MySqlConnectionStringBuilder();
        MySqlCommand MyConnection;
        string MyConString = "server=ftp.a0742318.xsph.ru;username=a0742318;password=hihenizive;database=a0742318_authorization_users;CharacterSet = utf8; AllowPublicKeyRetrieval=True";
        public Administration()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            #region Сортировка по убыванию id
            //this.dataGridViewDataTable.Sort(this.dataGridViewDataTable.Columns["id"], ListSortDirection.Ascending);
            ListSortDirection direction = (ListSortDirection)SortOrder.Ascending;
            dataGridViewDataTable.Sort(dataGridViewDataTable.Columns["id"], direction);
            #endregion
            #region Button Border
            buttonAddUser.FlatAppearance.BorderSize = 0;
            buttonAddUser.FlatStyle = FlatStyle.Flat;

            buttonDeleteAdm.FlatAppearance.BorderSize = 0;
            buttonDeleteAdm.FlatStyle = FlatStyle.Flat;

            buttonEditAdm.FlatAppearance.BorderSize = 0;
            buttonEditAdm.FlatStyle = FlatStyle.Flat;

            buttonUpdateGrid.FlatAppearance.BorderSize = 0;
            buttonUpdateGrid.FlatStyle = FlatStyle.Flat;
            #endregion
        }
        private void LoadDataIntoDataGridView()
        {
            string MyConString = "server=ftp.a0742318.xsph.ru;username=a0742318;password=hihenizive;database=a0742318_authorization_users;CharacterSet = utf8; AllowPublicKeyRetrieval=True";
            var MyConnection = new MySqlConnection(MyConString);
            MyConnection.Open();

            MySqlCommand cmd_Admin;

            cmd_Admin = MyConnection.CreateCommand();
            cmd_Admin.CommandText = ("SELECT * FROM `users`");

            MySqlDataReader sdr = cmd_Admin.ExecuteReader();

            DataTable dtRecorders = new DataTable();

            dtRecorders.Load(sdr);

            dataGridViewDataTable.DataSource = dtRecorders;
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }

        #region Buttons
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command_add_data = new MySqlCommand("INSERT INTO  `users` (`login`, `pass`, `name`, `number`, `email`, `role`) VALUES (@login,@pass,@name, @number,@email, @role)", db.GetConnection());
            command_add_data.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLoginAdm.Text;
            command_add_data.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPasswordAdm.Text;
            command_add_data.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxNameAdm.Text;
            command_add_data.Parameters.Add("@number", MySqlDbType.VarChar).Value = maskedTextBoxNumberAdm.Text;
            command_add_data.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmailAdm.Text;
            command_add_data.Parameters.Add("@role", MySqlDbType.VarChar).Value = textBoxRoleAdm.Text;

            db.openConnection();
            if (textBoxLoginAdm.Text == "" || textBoxPasswordAdm.Text == "" || textBoxNameAdm.Text == "" || maskedTextBoxNumberAdm.Text == "" || textBoxEmailAdm.Text == "" || textBoxRoleAdm.Text == "")
            {
                MessageBox.Show("Введите данные.");
            }
            else
            {
                if (command_add_data.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные были успешно добавленны!");
                else
                    MessageBox.Show("Ошибка! Данные не добавленны.");
            }
            string sql = "SELECT * FROM `users`";
            UpdateGrid(sql);
            db.closeConnection();
        }
        private void buttonEditAdm_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                db.openConnection();
                cmd = new MySqlCommand("UPDATE users SET login='" + textBoxLoginAdm.Text + "',pass='" + textBoxPasswordAdm.Text + "', name='" + textBoxNameAdm.Text + "', number='" + maskedTextBoxNumberAdm.Text + "', email='" + textBoxEmailAdm.Text + "', role='" + textBoxRoleAdm.Text + "' WHERE id='" + id + "'", db.GetConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Work");
                string sql = "SELECT * FROM `users`";
                UpdateGrid(sql);
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDeleteAdm_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "Вы действительно хотите удалить выделеную запись?";

            if (MessageBox.Show(Message, "внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            string id;
            id = dataGridViewDataTable.SelectedRows[0].Cells["id"].Value.ToString();

            string sql = "Delete from users where id =" + id;
            ExecSQL(sql);

            sql = "Select * from users";
            UpdateGrid(sql);

        }
        private void buttonUpdateGrid_Click(object sender, EventArgs e)
        {
            string sql = "Select * from users";
            UpdateGrid(sql);
        }

        #endregion
        #region Обновление данных в таблице 
        void UpdateGrid(string sql)
        {
            var MyConnection = new MySqlConnection(MyConString);
            MyConnection.Open();
            MySqlCommand cmd = MyConnection.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet m_set = new DataSet();
            adapter.Fill(m_set);

            dataGridViewDataTable.DataSource = m_set.Tables[0];
        }
        #endregion
        void ExecSQL(string sql)
        {
            var MyConnection = new MySqlConnection(MyConString);
            MyConnection.Open();
            MySqlCommand cmd = MyConnection.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        private void dataGridViewDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewDataTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxLoginAdm.Text = dataGridViewDataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPasswordAdm.Text = dataGridViewDataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxNameAdm.Text = dataGridViewDataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            maskedTextBoxNumberAdm.Text = dataGridViewDataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxEmailAdm.Text = dataGridViewDataTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxRoleAdm.Text = dataGridViewDataTable.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        #region Кнопка закрытия
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

        #region Передвижение окна
        Point lastPoint;
        private void panelAdm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            
        }
        private void panelAdm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
