namespace IB_1
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbEnter = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLK = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.panelAD = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.tbAddNewUser = new System.Windows.Forms.TextBox();
            this.btnSwitchPassRestr = new System.Windows.Forms.Button();
            this.btnSwitchBlock = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbEnter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelLK.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelAD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(85, 79);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(162, 23);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(85, 141);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(162, 23);
            this.tbPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(85, 193);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(162, 31);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbEnter
            // 
            this.gbEnter.Controls.Add(this.tbLogin);
            this.gbEnter.Controls.Add(this.btnEnter);
            this.gbEnter.Controls.Add(this.tbPassword);
            this.gbEnter.Controls.Add(this.label2);
            this.gbEnter.Controls.Add(this.label1);
            this.gbEnter.Location = new System.Drawing.Point(65, 56);
            this.gbEnter.Name = "gbEnter";
            this.gbEnter.Size = new System.Drawing.Size(301, 243);
            this.gbEnter.TabIndex = 4;
            this.gbEnter.TabStop = false;
            this.gbEnter.Text = "Вход в систему";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.входToolStripMenuItem.Text = "Вход";
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Enabled = false;
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.Enabled = false;
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            this.администрированиеToolStripMenuItem.Click += new System.EventHandler(this.администрированиеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panelLK
            // 
            this.panelLK.Controls.Add(this.label6);
            this.panelLK.Controls.Add(this.btnExit);
            this.panelLK.Controls.Add(this.groupBox1);
            this.panelLK.Location = new System.Drawing.Point(33, 27);
            this.panelLK.Name = "panelLK";
            this.panelLK.Size = new System.Drawing.Size(353, 288);
            this.panelLK.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(177, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Сменить пользователя";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNewPasswordAgain);
            this.groupBox1.Controls.Add(this.tbNewPassword);
            this.groupBox1.Controls.Add(this.tbOldPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить пароль";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(20, 172);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(117, 23);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Изменить пароль";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Подтверждение пароля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Старый пароль";
            // 
            // tbNewPasswordAgain
            // 
            this.tbNewPasswordAgain.Location = new System.Drawing.Point(8, 144);
            this.tbNewPasswordAgain.Name = "tbNewPasswordAgain";
            this.tbNewPasswordAgain.PasswordChar = '*';
            this.tbNewPasswordAgain.Size = new System.Drawing.Size(145, 20);
            this.tbNewPasswordAgain.TabIndex = 0;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(8, 98);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(145, 20);
            this.tbNewPassword.TabIndex = 0;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(8, 46);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(145, 20);
            this.tbOldPassword.TabIndex = 0;
            // 
            // panelAD
            // 
            this.panelAD.Controls.Add(this.button1);
            this.panelAD.Controls.Add(this.groupBox2);
            this.panelAD.Controls.Add(this.btnSwitchPassRestr);
            this.panelAD.Controls.Add(this.btnSwitchBlock);
            this.panelAD.Controls.Add(this.listUsers);
            this.panelAD.Location = new System.Drawing.Point(21, 31);
            this.panelAD.Name = "panelAD";
            this.panelAD.Size = new System.Drawing.Size(576, 294);
            this.panelAD.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAddNewUser);
            this.groupBox2.Controls.Add(this.tbAddNewUser);
            this.groupBox2.Location = new System.Drawing.Point(385, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить нового пользователя";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(69, 92);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(104, 23);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "Добавить";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // tbAddNewUser
            // 
            this.tbAddNewUser.Location = new System.Drawing.Point(4, 65);
            this.tbAddNewUser.Name = "tbAddNewUser";
            this.tbAddNewUser.Size = new System.Drawing.Size(169, 20);
            this.tbAddNewUser.TabIndex = 0;
            // 
            // btnSwitchPassRestr
            // 
            this.btnSwitchPassRestr.Location = new System.Drawing.Point(385, 59);
            this.btnSwitchPassRestr.Name = "btnSwitchPassRestr";
            this.btnSwitchPassRestr.Size = new System.Drawing.Size(173, 41);
            this.btnSwitchPassRestr.TabIndex = 1;
            this.btnSwitchPassRestr.Text = "Поставить/снять ограничение";
            this.btnSwitchPassRestr.UseVisualStyleBackColor = true;
            this.btnSwitchPassRestr.Click += new System.EventHandler(this.btnSwitchPassRestr_Click);
            // 
            // btnSwitchBlock
            // 
            this.btnSwitchBlock.Location = new System.Drawing.Point(385, 10);
            this.btnSwitchBlock.Name = "btnSwitchBlock";
            this.btnSwitchBlock.Size = new System.Drawing.Size(173, 43);
            this.btnSwitchBlock.TabIndex = 1;
            this.btnSwitchBlock.Text = "Изменить режим блокировки";
            this.btnSwitchBlock.UseVisualStyleBackColor = true;
            this.btnSwitchBlock.Click += new System.EventHandler(this.btnSwitchBlock_Click);
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(12, 10);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(358, 277);
            this.listUsers.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(177, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 65);
            this.label6.TabIndex = 3;
            this.label6.Text = "Пароль должен \r\nТОЛЬКО\r\nцифры\r\nи знаки препинания:\r\n - _ , . ! ; : ? ( )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Логин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 339);
            this.Controls.Add(this.panelAD);
            this.Controls.Add(this.panelLK);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbEnter);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ИБ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEnter.ResumeLayout(false);
            this.gbEnter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLK.ResumeLayout(false);
            this.panelLK.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAD.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox gbEnter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panelLK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPasswordAgain;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Panel panelAD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox tbAddNewUser;
        private System.Windows.Forms.Button btnSwitchPassRestr;
        private System.Windows.Forms.Button btnSwitchBlock;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

