
namespace GroupProject_OMG
{
    partial class Form1
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxCloseWindow = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxNumberReg = new System.Windows.Forms.MaskedTextBox();
            this.labelPasswordRegScan = new System.Windows.Forms.Label();
            this.labelPasswordAllValid = new System.Windows.Forms.Label();
            this.buttonUpdateCapcha = new System.Windows.Forms.Button();
            this.textBoxCapcha = new System.Windows.Forms.TextBox();
            this.pictureBoxCapcha = new System.Windows.Forms.PictureBox();
            this.buttonRegistrationEnter = new System.Windows.Forms.Button();
            this.textBoxPasswordRescanReg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.textBoxEmailReg = new System.Windows.Forms.TextBox();
            this.textBoxLoginReg = new System.Windows.Forms.TextBox();
            this.textBoxNameReg = new System.Windows.Forms.TextBox();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.labelRegistration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).BeginInit();
            this.panelRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmail.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEmail.Location = new System.Drawing.Point(117, 195);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 26);
            this.labelEmail.TabIndex = 76;
            this.labelEmail.Text = "Email";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumber.Location = new System.Drawing.Point(100, 158);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(83, 26);
            this.labelNumber.TabIndex = 75;
            this.labelNumber.Text = "Телефон";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPasswordRepeat.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelPasswordRepeat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPasswordRepeat.Location = new System.Drawing.Point(16, 279);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(167, 26);
            this.labelPasswordRepeat.TabIndex = 74;
            this.labelPasswordRepeat.Text = "Повторите пароль";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPassword.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPassword.Location = new System.Drawing.Point(110, 234);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 26);
            this.labelPassword.TabIndex = 73;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogin.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLogin.Location = new System.Drawing.Point(117, 123);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(66, 26);
            this.labelLogin.TabIndex = 72;
            this.labelLogin.Text = "Логин";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.labelName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelName.Location = new System.Drawing.Point(137, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 24);
            this.labelName.TabIndex = 71;
            this.labelName.Text = "Имя";
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
            // 
            // maskedTextBoxNumberReg
            // 
            this.maskedTextBoxNumberReg.Location = new System.Drawing.Point(188, 163);
            this.maskedTextBoxNumberReg.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxNumberReg.Mask = "+7(000)-00-00 00";
            this.maskedTextBoxNumberReg.Name = "maskedTextBoxNumberReg";
            this.maskedTextBoxNumberReg.Size = new System.Drawing.Size(220, 20);
            this.maskedTextBoxNumberReg.TabIndex = 69;
            // 
            // labelPasswordRegScan
            // 
            this.labelPasswordRegScan.AutoSize = true;
            this.labelPasswordRegScan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRegScan.Location = new System.Drawing.Point(188, 262);
            this.labelPasswordRegScan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordRegScan.Name = "labelPasswordRegScan";
            this.labelPasswordRegScan.Size = new System.Drawing.Size(15, 17);
            this.labelPasswordRegScan.TabIndex = 67;
            this.labelPasswordRegScan.Text = "1";
            this.labelPasswordRegScan.Visible = false;
            // 
            // labelPasswordAllValid
            // 
            this.labelPasswordAllValid.AutoSize = true;
            this.labelPasswordAllValid.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordAllValid.Location = new System.Drawing.Point(188, 307);
            this.labelPasswordAllValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordAllValid.Name = "labelPasswordAllValid";
            this.labelPasswordAllValid.Size = new System.Drawing.Size(15, 17);
            this.labelPasswordAllValid.TabIndex = 66;
            this.labelPasswordAllValid.Text = "2";
            this.labelPasswordAllValid.Visible = false;
            // 
            // buttonUpdateCapcha
            // 
            this.buttonUpdateCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(133)))));
            this.buttonUpdateCapcha.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.buttonUpdateCapcha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateCapcha.Location = new System.Drawing.Point(188, 445);
            this.buttonUpdateCapcha.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateCapcha.Name = "buttonUpdateCapcha";
            this.buttonUpdateCapcha.Size = new System.Drawing.Size(214, 36);
            this.buttonUpdateCapcha.TabIndex = 63;
            this.buttonUpdateCapcha.Text = "Обновить";
            this.buttonUpdateCapcha.UseVisualStyleBackColor = false;
            // 
            // textBoxCapcha
            // 
            this.textBoxCapcha.Location = new System.Drawing.Point(188, 406);
            this.textBoxCapcha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCapcha.Name = "textBoxCapcha";
            this.textBoxCapcha.Size = new System.Drawing.Size(214, 20);
            this.textBoxCapcha.TabIndex = 62;
            // 
            // pictureBoxCapcha
            // 
            this.pictureBoxCapcha.Location = new System.Drawing.Point(188, 326);
            this.pictureBoxCapcha.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCapcha.Name = "pictureBoxCapcha";
            this.pictureBoxCapcha.Size = new System.Drawing.Size(214, 76);
            this.pictureBoxCapcha.TabIndex = 61;
            this.pictureBoxCapcha.TabStop = false;
            // 
            // buttonRegistrationEnter
            // 
            this.buttonRegistrationEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(133)))));
            this.buttonRegistrationEnter.FlatAppearance.BorderSize = 0;
            this.buttonRegistrationEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonRegistrationEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.buttonRegistrationEnter.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrationEnter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegistrationEnter.Location = new System.Drawing.Point(188, 485);
            this.buttonRegistrationEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrationEnter.Name = "buttonRegistrationEnter";
            this.buttonRegistrationEnter.Size = new System.Drawing.Size(214, 36);
            this.buttonRegistrationEnter.TabIndex = 60;
            this.buttonRegistrationEnter.Text = "Зарегистрироваться";
            this.buttonRegistrationEnter.UseVisualStyleBackColor = false;
            // 
            // textBoxPasswordRescanReg
            // 
            this.textBoxPasswordRescanReg.Location = new System.Drawing.Point(188, 281);
            this.textBoxPasswordRescanReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordRescanReg.Multiline = true;
            this.textBoxPasswordRescanReg.Name = "textBoxPasswordRescanReg";
            this.textBoxPasswordRescanReg.Size = new System.Drawing.Size(220, 24);
            this.textBoxPasswordRescanReg.TabIndex = 50;
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Location = new System.Drawing.Point(188, 236);
            this.textBoxPasswordReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordReg.Multiline = true;
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(220, 24);
            this.textBoxPasswordReg.TabIndex = 49;
            // 
            // textBoxEmailReg
            // 
            this.textBoxEmailReg.Location = new System.Drawing.Point(188, 197);
            this.textBoxEmailReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailReg.Multiline = true;
            this.textBoxEmailReg.Name = "textBoxEmailReg";
            this.textBoxEmailReg.Size = new System.Drawing.Size(220, 24);
            this.textBoxEmailReg.TabIndex = 48;
            // 
            // textBoxLoginReg
            // 
            this.textBoxLoginReg.Location = new System.Drawing.Point(188, 125);
            this.textBoxLoginReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLoginReg.Multiline = true;
            this.textBoxLoginReg.Name = "textBoxLoginReg";
            this.textBoxLoginReg.Size = new System.Drawing.Size(220, 24);
            this.textBoxLoginReg.TabIndex = 47;
            // 
            // textBoxNameReg
            // 
            this.textBoxNameReg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNameReg.Location = new System.Drawing.Point(188, 91);
            this.textBoxNameReg.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameReg.Multiline = true;
            this.textBoxNameReg.Name = "textBoxNameReg";
            this.textBoxNameReg.Size = new System.Drawing.Size(220, 24);
            this.textBoxNameReg.TabIndex = 44;
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
            this.panelRegistration.Location = new System.Drawing.Point(-3, 0);
            this.panelRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(590, 593);
            this.panelRegistration.TabIndex = 1;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 593);
            this.Controls.Add(this.panelRegistration);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).EndInit();
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPasswordRepeat;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxCloseWindow;
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
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.Label labelRegistration;
    }
}