namespace GroupProject_OMG
{
    partial class NewPassword
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
            this.panelEditPassword = new System.Windows.Forms.Panel();
            this.pictureBoxCloseWindow = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelRebirth = new System.Windows.Forms.Label();
            this.panelEditPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditPassword
            // 
            this.panelEditPassword.BackgroundImage = global::GroupProject_OMG.Properties.Resources.fon_1;
            this.panelEditPassword.Controls.Add(this.pictureBoxCloseWindow);
            this.panelEditPassword.Controls.Add(this.button2);
            this.panelEditPassword.Controls.Add(this.button1);
            this.panelEditPassword.Controls.Add(this.textBoxNewPass2);
            this.panelEditPassword.Controls.Add(this.textBoxNewPass1);
            this.panelEditPassword.Controls.Add(this.textBoxCode);
            this.panelEditPassword.Controls.Add(this.labelRebirth);
            this.panelEditPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditPassword.Location = new System.Drawing.Point(0, 0);
            this.panelEditPassword.Name = "panelEditPassword";
            this.panelEditPassword.Size = new System.Drawing.Size(624, 370);
            this.panelEditPassword.TabIndex = 0;
            this.panelEditPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEditPassword_MouseDown);
            this.panelEditPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEditPassword_MouseMove);
            // 
            // pictureBoxCloseWindow
            // 
            this.pictureBoxCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseWindow.Image = global::GroupProject_OMG.Properties.Resources.pngwing_com;
            this.pictureBoxCloseWindow.Location = new System.Drawing.Point(548, 12);
            this.pictureBoxCloseWindow.Name = "pictureBoxCloseWindow";
            this.pictureBoxCloseWindow.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseWindow.TabIndex = 71;
            this.pictureBoxCloseWindow.TabStop = false;
            this.pictureBoxCloseWindow.Click += new System.EventHandler(this.pictureBoxCloseWindow_Click);
            this.pictureBoxCloseWindow.MouseEnter += new System.EventHandler(this.pictureBoxCloseWindow_MouseEnter);
            this.pictureBoxCloseWindow.MouseLeave += new System.EventHandler(this.pictureBoxCloseWindow_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GroupProject_OMG.Properties.Resources._1211212;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(363, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 38);
            this.button2.TabIndex = 50;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GroupProject_OMG.Properties.Resources.fon_1;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(303, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 45);
            this.button1.TabIndex = 49;
            this.button1.Text = "Изменить пароль";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Location = new System.Drawing.Point(25, 231);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.Size = new System.Drawing.Size(469, 22);
            this.textBoxNewPass2.TabIndex = 48;
            this.textBoxNewPass2.Enter += new System.EventHandler(this.textBoxNewPass2_Enter);
            this.textBoxNewPass2.Leave += new System.EventHandler(this.textBoxNewPass2_Leave);
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Location = new System.Drawing.Point(25, 175);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.Size = new System.Drawing.Size(469, 22);
            this.textBoxNewPass1.TabIndex = 47;
            this.textBoxNewPass1.Enter += new System.EventHandler(this.textBoxNewPass1_Enter);
            this.textBoxNewPass1.Leave += new System.EventHandler(this.textBoxNewPass1_Leave);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(25, 123);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(469, 22);
            this.textBoxCode.TabIndex = 46;
            this.textBoxCode.Enter += new System.EventHandler(this.textBoxCode_Enter);
            this.textBoxCode.Leave += new System.EventHandler(this.textBoxCode_Leave);
            // 
            // labelRebirth
            // 
            this.labelRebirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRebirth.AutoSize = true;
            this.labelRebirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRebirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRebirth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRebirth.Location = new System.Drawing.Point(12, 9);
            this.labelRebirth.Name = "labelRebirth";
            this.labelRebirth.Size = new System.Drawing.Size(482, 59);
            this.labelRebirth.TabIndex = 45;
            this.labelRebirth.Text = "Изменение пароля";
            this.labelRebirth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRebirth_MouseDown);
            this.labelRebirth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRebirth_MouseMove);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 370);
            this.Controls.Add(this.panelEditPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.Load += new System.EventHandler(this.NewPassword_Load);
            this.panelEditPassword.ResumeLayout(false);
            this.panelEditPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditPassword;
        private System.Windows.Forms.Label labelRebirth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.TextBox textBoxNewPass1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxCloseWindow;
    }
}