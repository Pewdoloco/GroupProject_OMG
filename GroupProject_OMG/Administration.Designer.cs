namespace GroupProject_OMG
{
    partial class Administration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBoxNumberAdm = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeleteAdm = new System.Windows.Forms.Button();
            this.buttonEditAdm = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewDataTable = new System.Windows.Forms.DataGridView();
            this.textBoxNameAdm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRoleAdm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoginAdm = new System.Windows.Forms.TextBox();
            this.textBoxEmailAdm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPasswordAdm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAdm = new System.Windows.Forms.Panel();
            this.pictureBoxCloseWindow = new System.Windows.Forms.PictureBox();
            this.buttonUpdateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataTable)).BeginInit();
            this.panelAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxNumberAdm
            // 
            this.maskedTextBoxNumberAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBoxNumberAdm.Location = new System.Drawing.Point(11, 211);
            this.maskedTextBoxNumberAdm.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxNumberAdm.Mask = "+7(000)-00-00 00";
            this.maskedTextBoxNumberAdm.Name = "maskedTextBoxNumberAdm";
            this.maskedTextBoxNumberAdm.Size = new System.Drawing.Size(199, 26);
            this.maskedTextBoxNumberAdm.TabIndex = 70;
            // 
            // buttonDeleteAdm
            // 
            this.buttonDeleteAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.buttonDeleteAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteAdm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteAdm.Location = new System.Drawing.Point(919, 386);
            this.buttonDeleteAdm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteAdm.Name = "buttonDeleteAdm";
            this.buttonDeleteAdm.Size = new System.Drawing.Size(103, 47);
            this.buttonDeleteAdm.TabIndex = 17;
            this.buttonDeleteAdm.Text = "Удалить";
            this.buttonDeleteAdm.UseVisualStyleBackColor = false;
            this.buttonDeleteAdm.Click += new System.EventHandler(this.buttonDeleteAdm_Click);
            // 
            // buttonEditAdm
            // 
            this.buttonEditAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(133)))));
            this.buttonEditAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditAdm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditAdm.Location = new System.Drawing.Point(547, 386);
            this.buttonEditAdm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditAdm.Name = "buttonEditAdm";
            this.buttonEditAdm.Size = new System.Drawing.Size(103, 47);
            this.buttonEditAdm.TabIndex = 16;
            this.buttonEditAdm.Text = "Изменить";
            this.buttonEditAdm.UseVisualStyleBackColor = false;
            this.buttonEditAdm.Click += new System.EventHandler(this.buttonEditAdm_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(133)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddUser.Location = new System.Drawing.Point(440, 386);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(103, 47);
            this.buttonAddUser.TabIndex = 15;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewDataTable
            // 
            this.dataGridViewDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataTable.Location = new System.Drawing.Point(271, 41);
            this.dataGridViewDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDataTable.Name = "dataGridViewDataTable";
            this.dataGridViewDataTable.RowHeadersWidth = 51;
            this.dataGridViewDataTable.RowTemplate.Height = 24;
            this.dataGridViewDataTable.Size = new System.Drawing.Size(751, 336);
            this.dataGridViewDataTable.TabIndex = 14;
            this.dataGridViewDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataTable_CellContentClick);
            // 
            // textBoxNameAdm
            // 
            this.textBoxNameAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNameAdm.Location = new System.Drawing.Point(11, 156);
            this.textBoxNameAdm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameAdm.Name = "textBoxNameAdm";
            this.textBoxNameAdm.Size = new System.Drawing.Size(199, 26);
            this.textBoxNameAdm.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(11, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Role";
            // 
            // textBoxRoleAdm
            // 
            this.textBoxRoleAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRoleAdm.Location = new System.Drawing.Point(11, 327);
            this.textBoxRoleAdm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoleAdm.Name = "textBoxRoleAdm";
            this.textBoxRoleAdm.Size = new System.Drawing.Size(199, 26);
            this.textBoxRoleAdm.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(11, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail";
            // 
            // textBoxLoginAdm
            // 
            this.textBoxLoginAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLoginAdm.Location = new System.Drawing.Point(11, 41);
            this.textBoxLoginAdm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLoginAdm.Name = "textBoxLoginAdm";
            this.textBoxLoginAdm.Size = new System.Drawing.Size(199, 26);
            this.textBoxLoginAdm.TabIndex = 2;
            // 
            // textBoxEmailAdm
            // 
            this.textBoxEmailAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailAdm.Location = new System.Drawing.Point(11, 269);
            this.textBoxEmailAdm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailAdm.Name = "textBoxEmailAdm";
            this.textBoxEmailAdm.Size = new System.Drawing.Size(199, 26);
            this.textBoxEmailAdm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(11, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number";
            // 
            // textBoxPasswordAdm
            // 
            this.textBoxPasswordAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPasswordAdm.Location = new System.Drawing.Point(11, 101);
            this.textBoxPasswordAdm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordAdm.Name = "textBoxPasswordAdm";
            this.textBoxPasswordAdm.Size = new System.Drawing.Size(199, 26);
            this.textBoxPasswordAdm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // panelAdm
            // 
            this.panelAdm.BackgroundImage = global::GroupProject_OMG.Properties.Resources.template__3_;
            this.panelAdm.Controls.Add(this.pictureBoxCloseWindow);
            this.panelAdm.Controls.Add(this.buttonUpdateGrid);
            this.panelAdm.Controls.Add(this.maskedTextBoxNumberAdm);
            this.panelAdm.Controls.Add(this.buttonDeleteAdm);
            this.panelAdm.Controls.Add(this.buttonEditAdm);
            this.panelAdm.Controls.Add(this.buttonAddUser);
            this.panelAdm.Controls.Add(this.dataGridViewDataTable);
            this.panelAdm.Controls.Add(this.textBoxNameAdm);
            this.panelAdm.Controls.Add(this.label7);
            this.panelAdm.Controls.Add(this.textBoxRoleAdm);
            this.panelAdm.Controls.Add(this.label6);
            this.panelAdm.Controls.Add(this.textBoxLoginAdm);
            this.panelAdm.Controls.Add(this.textBoxEmailAdm);
            this.panelAdm.Controls.Add(this.label2);
            this.panelAdm.Controls.Add(this.label5);
            this.panelAdm.Controls.Add(this.textBoxPasswordAdm);
            this.panelAdm.Controls.Add(this.label3);
            this.panelAdm.Controls.Add(this.label4);
            this.panelAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdm.Location = new System.Drawing.Point(0, 0);
            this.panelAdm.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdm.Name = "panelAdm";
            this.panelAdm.Size = new System.Drawing.Size(1100, 444);
            this.panelAdm.TabIndex = 15;
            this.panelAdm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAdm_MouseDown);
            this.panelAdm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAdm_MouseMove);
            // 
            // pictureBoxCloseWindow
            // 
            this.pictureBoxCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseWindow.Image = global::GroupProject_OMG.Properties.Resources.pngwing_com;
            this.pictureBoxCloseWindow.Location = new System.Drawing.Point(1042, 10);
            this.pictureBoxCloseWindow.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCloseWindow.Name = "pictureBoxCloseWindow";
            this.pictureBoxCloseWindow.Size = new System.Drawing.Size(48, 52);
            this.pictureBoxCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseWindow.TabIndex = 72;
            this.pictureBoxCloseWindow.TabStop = false;
            this.pictureBoxCloseWindow.Click += new System.EventHandler(this.pictureBoxCloseWindow_Click);
            // 
            // buttonUpdateGrid
            // 
            this.buttonUpdateGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(133)))));
            this.buttonUpdateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUpdateGrid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateGrid.Location = new System.Drawing.Point(271, 386);
            this.buttonUpdateGrid.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateGrid.Name = "buttonUpdateGrid";
            this.buttonUpdateGrid.Size = new System.Drawing.Size(165, 47);
            this.buttonUpdateGrid.TabIndex = 71;
            this.buttonUpdateGrid.Text = "Обновить таблицу";
            this.buttonUpdateGrid.UseVisualStyleBackColor = false;
            this.buttonUpdateGrid.Click += new System.EventHandler(this.buttonUpdateGrid_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 444);
            this.Controls.Add(this.panelAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Administration";
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataTable)).EndInit();
            this.panelAdm.ResumeLayout(false);
            this.panelAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberAdm;
        private System.Windows.Forms.Button buttonDeleteAdm;
        private System.Windows.Forms.Button buttonEditAdm;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridView dataGridViewDataTable;
        private System.Windows.Forms.TextBox textBoxNameAdm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRoleAdm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoginAdm;
        private System.Windows.Forms.TextBox textBoxEmailAdm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPasswordAdm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAdm;
        private System.Windows.Forms.Button buttonUpdateGrid;
        private System.Windows.Forms.PictureBox pictureBoxCloseWindow;
    }
}