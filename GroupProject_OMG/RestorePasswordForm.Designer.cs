namespace GroupProject_OMG
{
    partial class RestorePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestorePasswordForm));
            this.panelRestore = new System.Windows.Forms.Panel();
            this.pictureBoxCloseWindow = new System.Windows.Forms.PictureBox();
            this.buttonRestoreEnter = new System.Windows.Forms.Button();
            this.labelRestore = new System.Windows.Forms.Label();
            this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
            this.textBoxRestore = new System.Windows.Forms.TextBox();
            this.labelEmailRestore = new System.Windows.Forms.Label();
            this.panelRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRestore
            // 
            this.panelRestore.BackgroundImage = global::GroupProject_OMG.Properties.Resources.fon_1;
            this.panelRestore.Controls.Add(this.pictureBoxCloseWindow);
            this.panelRestore.Controls.Add(this.buttonRestoreEnter);
            this.panelRestore.Controls.Add(this.labelRestore);
            this.panelRestore.Controls.Add(this.pictureBoxRestore);
            this.panelRestore.Controls.Add(this.textBoxRestore);
            this.panelRestore.Controls.Add(this.labelEmailRestore);
            this.panelRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelRestore.Location = new System.Drawing.Point(0, 0);
            this.panelRestore.Name = "panelRestore";
            this.panelRestore.Size = new System.Drawing.Size(881, 308);
            this.panelRestore.TabIndex = 0;
            this.panelRestore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRestore_MouseDown);
            this.panelRestore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRestore_MouseMove);
            // 
            // pictureBoxCloseWindow
            // 
            this.pictureBoxCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseWindow.Image = global::GroupProject_OMG.Properties.Resources.pngwing_com;
            this.pictureBoxCloseWindow.Location = new System.Drawing.Point(805, 12);
            this.pictureBoxCloseWindow.Name = "pictureBoxCloseWindow";
            this.pictureBoxCloseWindow.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseWindow.TabIndex = 71;
            this.pictureBoxCloseWindow.TabStop = false;
            this.pictureBoxCloseWindow.Click += new System.EventHandler(this.pictureBoxCloseWindow_Click);
            this.pictureBoxCloseWindow.MouseEnter += new System.EventHandler(this.pictureBoxCloseWindow_MouseEnter);
            this.pictureBoxCloseWindow.MouseLeave += new System.EventHandler(this.pictureBoxCloseWindow_MouseLeave);
            // 
            // buttonRestoreEnter
            // 
            this.buttonRestoreEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRestoreEnter.BackgroundImage = global::GroupProject_OMG.Properties.Resources.fon_1;
            this.buttonRestoreEnter.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.buttonRestoreEnter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRestoreEnter.Location = new System.Drawing.Point(421, 249);
            this.buttonRestoreEnter.Name = "buttonRestoreEnter";
            this.buttonRestoreEnter.Size = new System.Drawing.Size(267, 37);
            this.buttonRestoreEnter.TabIndex = 61;
            this.buttonRestoreEnter.Text = "Восстановить Пароль";
            this.buttonRestoreEnter.UseVisualStyleBackColor = false;
            this.buttonRestoreEnter.Click += new System.EventHandler(this.buttonRegistrationEnter_Click);
            // 
            // labelRestore
            // 
            this.labelRestore.AutoSize = true;
            this.labelRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRestore.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRestore.Location = new System.Drawing.Point(103, 25);
            this.labelRestore.Name = "labelRestore";
            this.labelRestore.Size = new System.Drawing.Size(630, 59);
            this.labelRestore.TabIndex = 43;
            this.labelRestore.Text = "Восстановление пароля";
            this.labelRestore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRestore_MouseDown);
            this.labelRestore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRestore_MouseMove);
            // 
            // pictureBoxRestore
            // 
            this.pictureBoxRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxRestore.Image = global::GroupProject_OMG.Properties.Resources.user_icon;
            this.pictureBoxRestore.Location = new System.Drawing.Point(113, 148);
            this.pictureBoxRestore.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxRestore.Name = "pictureBoxRestore";
            this.pictureBoxRestore.Size = new System.Drawing.Size(85, 79);
            this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestore.TabIndex = 41;
            this.pictureBoxRestore.TabStop = false;
            // 
            // textBoxRestore
            // 
            this.textBoxRestore.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxRestore.Location = new System.Drawing.Point(223, 197);
            this.textBoxRestore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRestore.Name = "textBoxRestore";
            this.textBoxRestore.Size = new System.Drawing.Size(465, 22);
            this.textBoxRestore.TabIndex = 38;
            // 
            // labelEmailRestore
            // 
            this.labelEmailRestore.AutoSize = true;
            this.labelEmailRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmailRestore.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmailRestore.ForeColor = System.Drawing.Color.White;
            this.labelEmailRestore.Location = new System.Drawing.Point(216, 148);
            this.labelEmailRestore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailRestore.Name = "labelEmailRestore";
            this.labelEmailRestore.Size = new System.Drawing.Size(223, 35);
            this.labelEmailRestore.TabIndex = 37;
            this.labelEmailRestore.Text = "Введите Email : ";
            // 
            // RestorePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 308);
            this.Controls.Add(this.panelRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestorePasswordForm";
            this.Text = "RestorePasswordForm";
            this.panelRestore.ResumeLayout(false);
            this.panelRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRestore;
        private System.Windows.Forms.Label labelRestore;
        private System.Windows.Forms.PictureBox pictureBoxRestore;
        private System.Windows.Forms.TextBox textBoxRestore;
        private System.Windows.Forms.Label labelEmailRestore;
        private System.Windows.Forms.Button buttonRestoreEnter;
        private System.Windows.Forms.PictureBox pictureBoxCloseWindow;
    }
}