namespace GroupProject_OMG
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.pictureBoxCloseWindow = new System.Windows.Forms.PictureBox();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.textBoxNameReg = new System.Windows.Forms.TextBox();
            this.textBoxLoginReg = new System.Windows.Forms.TextBox();
            this.textBoxEmailReg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRescanReg = new System.Windows.Forms.TextBox();
            this.buttonRegistrationEnter = new System.Windows.Forms.Button();
            this.pictureBoxCapcha = new System.Windows.Forms.PictureBox();
            this.textBoxCapcha = new System.Windows.Forms.TextBox();
            this.buttonUpdateCapcha = new System.Windows.Forms.Button();
            this.labelPasswordAllValid = new System.Windows.Forms.Label();
            this.labelPasswordRegScan = new System.Windows.Forms.Label();
            this.maskedTextBoxNumberReg = new System.Windows.Forms.MaskedTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).BeginInit();
            this.panelRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCloseWindow
            // 
            this.pictureBoxCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseWindow.Image = global::GroupProject_OMG.Properties.Resources.pngwing_com;
            this.pictureBoxCloseWindow.Location = new System.Drawing.Point(678, 11);
            this.pictureBoxCloseWindow.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCloseWindow.Name = "pictureBoxCloseWindow";
            this.pictureBoxCloseWindow.Size = new System.Drawing.Size(48, 52);
            this.pictureBoxCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseWindow.TabIndex = 70;
            this.pictureBoxCloseWindow.TabStop = false;
            this.pictureBoxCloseWindow.Click += new System.EventHandler(this.pictureBoxCloseWindow_Click);
            this.pictureBoxCloseWindow.MouseEnter += new System.EventHandler(this.pictureBoxCloseWindow_MouseEnter);
            this.pictureBoxCloseWindow.MouseLeave += new System.EventHandler(this.pictureBoxCloseWindow_MouseLeave_1);
            // 
            // panelRegistration
            // 
            this.panelRegistration.BackgroundImage = global::GroupProject_OMG.Properties.Resources.template__3_;
            this.panelRegistration.Controls.Add(this.labelEmail);
            this.panelRegistration.Controls.Add(this.labelNumber);
            this.panelRegistration.Controls.Add(this.labelPasswordRepeat);
            this.panelRegistration.Controls.Add(this.labelPassword);
            this.panelRegistration.Controls.Add(this.labelLogin);
            this.panelRegistration.Controls.Add(this.labelName);
            this.panelRegistration.Controls.Add(this.pictureBoxCloseWindow);
            this.panelRegistration.Controls.Add(this.maskedTextBoxNumberReg);
            this.panelRegistration.Controls.Add(this.labelPasswordRegScan);
            this.panelRegistration.Controls.Add(this.labelPasswordAllValid);
            this.panelRegistration.Controls.Add(this.buttonUpdateCapcha);
            this.panelRegistration.Controls.Add(this.textBoxCapcha);
            this.panelRegistration.Controls.Add(this.pictureBoxCapcha);
            this.panelRegistration.Controls.Add(this.buttonRegistrationEnter);
            this.panelRegistration.Controls.Add(this.textBoxPasswordRescanReg);
            this.panelRegistration.Controls.Add(this.textBoxPasswordReg);
            this.panelRegistration.Controls.Add(this.textBoxEmailReg);
            this.panelRegistration.Controls.Add(this.textBoxLoginReg);
            this.panelRegistration.Controls.Add(this.textBoxNameReg);
            this.panelRegistration.Controls.Add(this.labelRegistration);
            this.panelRegistration.Location = new System.Drawing.Point(0, 0);
            this.panelRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(563, 581);
            this.panelRegistration.TabIndex = 0;
            this.panelRegistration.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegistration_Paint);
            this.panelRegistration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistration_MouseDown_1);
            this.panelRegistration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRegistration_MouseMove_1);
            // 
            // labelRegistration
            // 
            this.labelRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRegistration.Font = new System.Drawing.Font("MS Reference Sans Serif", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegistration.Location = new System.Drawing.Point(151, 9);
            this.labelRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(277, 46);
            this.labelRegistration.TabIndex = 43;
            this.labelRegistration.Text = "Регистрация";
            this.labelRegistration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRegistration_MouseDown);
            this.labelRegistration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRegistration_MouseMove);
            // 
            // textBoxNameReg
            // 
            this.textBoxNameReg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameReg.Location = new System.Drawing.Point(188, 91);
            this.textBoxNameReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameReg.Name = "textBoxNameReg";
            this.textBoxNameReg.Size = new System.Drawing.Size(220, 26);
            this.textBoxNameReg.TabIndex = 44;
            this.textBoxNameReg.TextChanged += new System.EventHandler(this.textBoxNameReg_TextChanged);
            this.textBoxNameReg.Enter += new System.EventHandler(this.textBoxNameReg_Enter);
            this.textBoxNameReg.Leave += new System.EventHandler(this.textBoxNameReg_Leave);
            // 
            // textBoxLoginReg
            // 
            this.textBoxLoginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginReg.Location = new System.Drawing.Point(188, 124);
            this.textBoxLoginReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLoginReg.Name = "textBoxLoginReg";
            this.textBoxLoginReg.Size = new System.Drawing.Size(220, 26);
            this.textBoxLoginReg.TabIndex = 47;
            this.textBoxLoginReg.TextChanged += new System.EventHandler(this.textBoxLoginReg_TextChanged);
            this.textBoxLoginReg.Enter += new System.EventHandler(this.textBoxLoginReg_Enter);
            this.textBoxLoginReg.Leave += new System.EventHandler(this.textBoxLoginReg_Leave);
            // 
            // textBoxEmailReg
            // 
            this.textBoxEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmailReg.Location = new System.Drawing.Point(188, 189);
            this.textBoxEmailReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailReg.Name = "textBoxEmailReg";
            this.textBoxEmailReg.Size = new System.Drawing.Size(220, 26);
            this.textBoxEmailReg.TabIndex = 48;
            this.textBoxEmailReg.Enter += new System.EventHandler(this.textBoxEmailReg_Enter);
            this.textBoxEmailReg.Leave += new System.EventHandler(this.textBoxEmailReg_Leave);
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordReg.Location = new System.Drawing.Point(188, 223);
            this.textBoxPasswordReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(220, 26);
            this.textBoxPasswordReg.TabIndex = 49;
            this.textBoxPasswordReg.TextChanged += new System.EventHandler(this.textBoxPasswordReg_TextChanged);
            this.textBoxPasswordReg.Enter += new System.EventHandler(this.textBoxPasswordReg_Enter);
            this.textBoxPasswordReg.Leave += new System.EventHandler(this.textBoxPasswordReg_Leave);
            // 
            // textBoxPasswordRescanReg
            // 
            this.textBoxPasswordRescanReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordRescanReg.Location = new System.Drawing.Point(188, 272);
            this.textBoxPasswordRescanReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordRescanReg.Name = "textBoxPasswordRescanReg";
            this.textBoxPasswordRescanReg.Size = new System.Drawing.Size(220, 26);
            this.textBoxPasswordRescanReg.TabIndex = 50;
            this.textBoxPasswordRescanReg.TextChanged += new System.EventHandler(this.textBoxPasswordRescanReg_TextChanged);
            this.textBoxPasswordRescanReg.Enter += new System.EventHandler(this.textBoxPasswordRescanReg_Enter);
            this.textBoxPasswordRescanReg.Leave += new System.EventHandler(this.textBoxPasswordRescanReg_Leave);
            // 
            // buttonRegistrationEnter
            // 
            this.buttonRegistrationEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonRegistrationEnter.FlatAppearance.BorderSize = 0;
            this.buttonRegistrationEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonRegistrationEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.buttonRegistrationEnter.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrationEnter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegistrationEnter.Location = new System.Drawing.Point(188, 498);
            this.buttonRegistrationEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrationEnter.Name = "buttonRegistrationEnter";
            this.buttonRegistrationEnter.Size = new System.Drawing.Size(214, 36);
            this.buttonRegistrationEnter.TabIndex = 60;
            this.buttonRegistrationEnter.Text = "Зарегистрироваться";
            this.buttonRegistrationEnter.UseVisualStyleBackColor = false;
            this.buttonRegistrationEnter.Click += new System.EventHandler(this.buttonRegistrationEnter_Click);
            // 
            // pictureBoxCapcha
            // 
            this.pictureBoxCapcha.Location = new System.Drawing.Point(188, 337);
            this.pictureBoxCapcha.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCapcha.Name = "pictureBoxCapcha";
            this.pictureBoxCapcha.Size = new System.Drawing.Size(214, 76);
            this.pictureBoxCapcha.TabIndex = 61;
            this.pictureBoxCapcha.TabStop = false;
            // 
            // textBoxCapcha
            // 
            this.textBoxCapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCapcha.Location = new System.Drawing.Point(188, 426);
            this.textBoxCapcha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCapcha.Name = "textBoxCapcha";
            this.textBoxCapcha.Size = new System.Drawing.Size(214, 26);
            this.textBoxCapcha.TabIndex = 62;
            this.textBoxCapcha.Enter += new System.EventHandler(this.textBoxCapcha_Enter);
            this.textBoxCapcha.Leave += new System.EventHandler(this.textBoxCapcha_Leave);
            // 
            // buttonUpdateCapcha
            // 
            this.buttonUpdateCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(20)))), ((int)(((byte)(150)))));
            this.buttonUpdateCapcha.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.buttonUpdateCapcha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateCapcha.Location = new System.Drawing.Point(188, 458);
            this.buttonUpdateCapcha.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateCapcha.Name = "buttonUpdateCapcha";
            this.buttonUpdateCapcha.Size = new System.Drawing.Size(214, 36);
            this.buttonUpdateCapcha.TabIndex = 63;
            this.buttonUpdateCapcha.Text = "Обновить";
            this.buttonUpdateCapcha.UseVisualStyleBackColor = false;
            this.buttonUpdateCapcha.Click += new System.EventHandler(this.buttonUpdateCapcha_Click);
            // 
            // labelPasswordAllValid
            // 
            this.labelPasswordAllValid.AutoSize = true;
            this.labelPasswordAllValid.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordAllValid.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordAllValid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPasswordAllValid.Location = new System.Drawing.Point(189, 300);
            this.labelPasswordAllValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordAllValid.Name = "labelPasswordAllValid";
            this.labelPasswordAllValid.Size = new System.Drawing.Size(15, 17);
            this.labelPasswordAllValid.TabIndex = 66;
            this.labelPasswordAllValid.Text = "2";
            this.labelPasswordAllValid.Visible = false;
            // 
            // labelPasswordRegScan
            // 
            this.labelPasswordRegScan.AutoSize = true;
            this.labelPasswordRegScan.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordRegScan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRegScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPasswordRegScan.Location = new System.Drawing.Point(189, 250);
            this.labelPasswordRegScan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordRegScan.Name = "labelPasswordRegScan";
            this.labelPasswordRegScan.Size = new System.Drawing.Size(15, 17);
            this.labelPasswordRegScan.TabIndex = 67;
            this.labelPasswordRegScan.Text = "1";
            this.labelPasswordRegScan.Visible = false;
            // 
            // maskedTextBoxNumberReg
            // 
            this.maskedTextBoxNumberReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxNumberReg.Location = new System.Drawing.Point(188, 155);
            this.maskedTextBoxNumberReg.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxNumberReg.Mask = "+7(000)-00-00 00";
            this.maskedTextBoxNumberReg.Name = "maskedTextBoxNumberReg";
            this.maskedTextBoxNumberReg.Size = new System.Drawing.Size(220, 26);
            this.maskedTextBoxNumberReg.TabIndex = 69;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelName.Location = new System.Drawing.Point(128, 87);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 24);
            this.labelName.TabIndex = 71;
            this.labelName.Text = "Имя";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLogin.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLogin.Location = new System.Drawing.Point(117, 122);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 24);
            this.labelLogin.TabIndex = 72;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPassword.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPassword.Location = new System.Drawing.Point(110, 223);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 24);
            this.labelPassword.TabIndex = 73;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPasswordRepeat.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelPasswordRepeat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPasswordRepeat.Location = new System.Drawing.Point(16, 272);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(165, 24);
            this.labelPasswordRepeat.TabIndex = 74;
            this.labelPasswordRepeat.Text = "Повторите пароль";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumber.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumber.Location = new System.Drawing.Point(100, 155);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(81, 24);
            this.labelNumber.TabIndex = 75;
            this.labelNumber.Text = "Телефон";
            this.labelNumber.Click += new System.EventHandler(this.labelNumber_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmail.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEmail.Location = new System.Drawing.Point(124, 189);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 24);
            this.labelEmail.TabIndex = 76;
            this.labelEmail.Text = "Email";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 581);
            this.Controls.Add(this.panelRegistration);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).EndInit();
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCloseWindow;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPasswordRepeat;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberReg;
        private System.Windows.Forms.Label labelPasswordRegScan;
        private System.Windows.Forms.Label labelPasswordAllValid;
        private System.Windows.Forms.Button buttonUpdateCapcha;
        private System.Windows.Forms.TextBox textBoxCapcha;
        private System.Windows.Forms.PictureBox pictureBoxCapcha;
        private System.Windows.Forms.Button buttonRegistrationEnter;
        private System.Windows.Forms.TextBox textBoxPasswordRescanReg;
        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.TextBox textBoxEmailReg;
        private System.Windows.Forms.TextBox textBoxLoginReg;
        private System.Windows.Forms.TextBox textBoxNameReg;
        private System.Windows.Forms.Label labelRegistration;
    }
}