namespace GroupProject_OMG
{
    partial class MainForm
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
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFolderPathSave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewLocal = new System.Windows.Forms.ListView();
            this.listViewCloud = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadFileOnLocal = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.buttonDeleteFromLocal = new System.Windows.Forms.Button();
            this.buttonLoadFolderOnLocal = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonLoadFolderOnCloud = new System.Windows.Forms.Button();
            this.buttonDeleteFromCloud = new System.Windows.Forms.Button();
            this.buttonLoadFileOnCloud = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFolderPathSave
            // 
            this.textBoxFolderPathSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFolderPathSave.Location = new System.Drawing.Point(16, 520);
            this.textBoxFolderPathSave.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFolderPathSave.Name = "textBoxFolderPathSave";
            this.textBoxFolderPathSave.ReadOnly = true;
            this.textBoxFolderPathSave.Size = new System.Drawing.Size(395, 26);
            this.textBoxFolderPathSave.TabIndex = 3;
            this.textBoxFolderPathSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFolderPathSave_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 498);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Файл будет сохранен по следующему пути:";
            // 
            // listViewLocal
            // 
            this.listViewLocal.HideSelection = false;
            this.listViewLocal.Location = new System.Drawing.Point(16, 95);
            this.listViewLocal.Margin = new System.Windows.Forms.Padding(2);
            this.listViewLocal.Name = "listViewLocal";
            this.listViewLocal.Size = new System.Drawing.Size(609, 380);
            this.listViewLocal.TabIndex = 5;
            this.listViewLocal.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCloud
            // 
            this.listViewCloud.HideSelection = false;
            this.listViewCloud.Location = new System.Drawing.Point(691, 95);
            this.listViewCloud.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCloud.Name = "listViewCloud";
            this.listViewCloud.Size = new System.Drawing.Size(609, 380);
            this.listViewCloud.TabIndex = 6;
            this.listViewCloud.UseCompatibleStateImageBehavior = false;
            this.listViewCloud.SelectedIndexChanged += new System.EventHandler(this.listViewCloud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(641, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = ">";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(641, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "<";
            // 
            // buttonLoadFileOnLocal
            // 
            this.buttonLoadFileOnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonLoadFileOnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLoadFileOnLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoadFileOnLocal.Location = new System.Drawing.Point(17, 12);
            this.buttonLoadFileOnLocal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadFileOnLocal.Name = "buttonLoadFileOnLocal";
            this.buttonLoadFileOnLocal.Size = new System.Drawing.Size(200, 60);
            this.buttonLoadFileOnLocal.TabIndex = 9;
            this.buttonLoadFileOnLocal.Text = "Загрузить файл в локальное хранилище";
            this.buttonLoadFileOnLocal.UseVisualStyleBackColor = false;
            // 
            // buttonSync
            // 
            this.buttonSync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSync.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSync.Location = new System.Drawing.Point(1100, 487);
            this.buttonSync.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(200, 60);
            this.buttonSync.TabIndex = 12;
            this.buttonSync.Text = "Синхронизировать данные";
            this.buttonSync.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteFromLocal
            // 
            this.buttonDeleteFromLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonDeleteFromLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteFromLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteFromLocal.Location = new System.Drawing.Point(425, 12);
            this.buttonDeleteFromLocal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteFromLocal.Name = "buttonDeleteFromLocal";
            this.buttonDeleteFromLocal.Size = new System.Drawing.Size(200, 60);
            this.buttonDeleteFromLocal.TabIndex = 13;
            this.buttonDeleteFromLocal.Text = "Удалить из локального хранилища";
            this.buttonDeleteFromLocal.UseVisualStyleBackColor = false;
            // 
            // buttonLoadFolderOnLocal
            // 
            this.buttonLoadFolderOnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonLoadFolderOnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLoadFolderOnLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoadFolderOnLocal.Location = new System.Drawing.Point(221, 12);
            this.buttonLoadFolderOnLocal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadFolderOnLocal.Name = "buttonLoadFolderOnLocal";
            this.buttonLoadFolderOnLocal.Size = new System.Drawing.Size(200, 60);
            this.buttonLoadFolderOnLocal.TabIndex = 15;
            this.buttonLoadFolderOnLocal.Text = "Загрузить папку в локальное хранилище";
            this.buttonLoadFolderOnLocal.UseVisualStyleBackColor = false;
            // 
            // buttonLoadFolderOnCloud
            // 
            this.buttonLoadFolderOnCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonLoadFolderOnCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLoadFolderOnCloud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoadFolderOnCloud.Location = new System.Drawing.Point(895, 12);
            this.buttonLoadFolderOnCloud.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadFolderOnCloud.Name = "buttonLoadFolderOnCloud";
            this.buttonLoadFolderOnCloud.Size = new System.Drawing.Size(200, 60);
            this.buttonLoadFolderOnCloud.TabIndex = 18;
            this.buttonLoadFolderOnCloud.Text = "Загрузить папку в облако";
            this.buttonLoadFolderOnCloud.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteFromCloud
            // 
            this.buttonDeleteFromCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonDeleteFromCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteFromCloud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteFromCloud.Location = new System.Drawing.Point(1100, 12);
            this.buttonDeleteFromCloud.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteFromCloud.Name = "buttonDeleteFromCloud";
            this.buttonDeleteFromCloud.Size = new System.Drawing.Size(200, 60);
            this.buttonDeleteFromCloud.TabIndex = 17;
            this.buttonDeleteFromCloud.Text = "Удалить из облака";
            this.buttonDeleteFromCloud.UseVisualStyleBackColor = false;
            // 
            // buttonLoadFileOnCloud
            // 
            this.buttonLoadFileOnCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonLoadFileOnCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLoadFileOnCloud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoadFileOnCloud.Location = new System.Drawing.Point(691, 12);
            this.buttonLoadFileOnCloud.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadFileOnCloud.Name = "buttonLoadFileOnCloud";
            this.buttonLoadFileOnCloud.Size = new System.Drawing.Size(200, 60);
            this.buttonLoadFileOnCloud.TabIndex = 16;
            this.buttonLoadFileOnCloud.Text = "Загрузить файл в облако";
            this.buttonLoadFileOnCloud.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GroupProject_OMG.Properties.Resources.template__3_;
            this.panel1.Controls.Add(this.listViewLocal);
            this.panel1.Controls.Add(this.listViewCloud);
            this.panel1.Controls.Add(this.buttonLoadFolderOnCloud);
            this.panel1.Controls.Add(this.textBoxFolderPathSave);
            this.panel1.Controls.Add(this.buttonDeleteFromCloud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonLoadFileOnCloud);
            this.panel1.Controls.Add(this.buttonLoadFolderOnLocal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDeleteFromLocal);
            this.panel1.Controls.Add(this.buttonLoadFileOnLocal);
            this.panel1.Controls.Add(this.buttonSync);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 748);
            this.panel1.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 862);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
        private System.Windows.Forms.TextBox textBoxFolderPathSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewLocal;
        private System.Windows.Forms.ListView listViewCloud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadFileOnLocal;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.Button buttonDeleteFromLocal;
        private System.Windows.Forms.Button buttonLoadFolderOnLocal;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonLoadFolderOnCloud;
        private System.Windows.Forms.Button buttonDeleteFromCloud;
        private System.Windows.Forms.Button buttonLoadFileOnCloud;
        private System.Windows.Forms.Panel panel1;
    }
}