namespace FirstForm
{
    partial class DDNet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDNet));
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdminRconPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMapName = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxEnablePassword = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxModPassword = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxHelperPassword = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWelcomeMessage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxmotd = new System.Windows.Forms.TextBox();
            this.buttonAddVotes = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxTestDDrace = new System.Windows.Forms.CheckBox();
            this.checkBoxRegisterServer = new System.Windows.Forms.CheckBox();
            this.checkBoxTournamentMode = new System.Windows.Forms.CheckBox();
            this.checkBoxPausable = new System.Windows.Forms.CheckBox();
            this.checkBoxRescue = new System.Windows.Forms.CheckBox();
            this.checkBoxRankCheats = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(12, 138);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(134, 20);
            this.textBoxServerName.TabIndex = 0;
            this.textBoxServerName.Text = "My DDNet server";
            this.textBoxServerName.TextChanged += new System.EventHandler(this.textBoxServerName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server Port";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(12, 202);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(134, 20);
            this.textBoxServerPort.TabIndex = 3;
            this.textBoxServerPort.Text = "8303";
            this.textBoxServerPort.TextChanged += new System.EventHandler(this.textBoxServerPort_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Admin Rcon Password";
            // 
            // textBoxAdminRconPassword
            // 
            this.textBoxAdminRconPassword.Location = new System.Drawing.Point(12, 271);
            this.textBoxAdminRconPassword.Name = "textBoxAdminRconPassword";
            this.textBoxAdminRconPassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxAdminRconPassword.TabIndex = 5;
            this.textBoxAdminRconPassword.TextChanged += new System.EventHandler(this.textBoxAdminRconPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Map Name";
            // 
            // textBoxMapName
            // 
            this.textBoxMapName.Location = new System.Drawing.Point(12, 466);
            this.textBoxMapName.Name = "textBoxMapName";
            this.textBoxMapName.Size = new System.Drawing.Size(134, 20);
            this.textBoxMapName.TabIndex = 7;
            this.textBoxMapName.Text = "Kobra 4";
            this.textBoxMapName.TextChanged += new System.EventHandler(this.textBoxMapName_TextChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(345, 597);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(108, 39);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // checkBoxEnablePassword
            // 
            this.checkBoxEnablePassword.AutoSize = true;
            this.checkBoxEnablePassword.Location = new System.Drawing.Point(152, 525);
            this.checkBoxEnablePassword.Name = "checkBoxEnablePassword";
            this.checkBoxEnablePassword.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEnablePassword.TabIndex = 11;
            this.checkBoxEnablePassword.Text = "Enable";
            this.checkBoxEnablePassword.UseVisualStyleBackColor = true;
            this.checkBoxEnablePassword.CheckedChanged += new System.EventHandler(this.checkBoxEnablePassword_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mod Rcon Password";
            // 
            // maskedTextBoxModPassword
            // 
            this.maskedTextBoxModPassword.Location = new System.Drawing.Point(12, 342);
            this.maskedTextBoxModPassword.Name = "maskedTextBoxModPassword";
            this.maskedTextBoxModPassword.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxModPassword.TabIndex = 13;
            this.maskedTextBoxModPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxModPassword_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Helper Rcon Password";
            // 
            // maskedTextBoxHelperPassword
            // 
            this.maskedTextBoxHelperPassword.Location = new System.Drawing.Point(12, 404);
            this.maskedTextBoxHelperPassword.Name = "maskedTextBoxHelperPassword";
            this.maskedTextBoxHelperPassword.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxHelperPassword.TabIndex = 15;
            this.maskedTextBoxHelperPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxHelperPassword_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Welcome message";
            // 
            // textBoxWelcomeMessage
            // 
            this.textBoxWelcomeMessage.Location = new System.Drawing.Point(228, 293);
            this.textBoxWelcomeMessage.Name = "textBoxWelcomeMessage";
            this.textBoxWelcomeMessage.Size = new System.Drawing.Size(205, 20);
            this.textBoxWelcomeMessage.TabIndex = 18;
            this.textBoxWelcomeMessage.TextChanged += new System.EventHandler(this.textBoxWelcomeMessage_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "MOTD";
            // 
            // textBoxmotd
            // 
            this.textBoxmotd.Location = new System.Drawing.Point(228, 343);
            this.textBoxmotd.Name = "textBoxmotd";
            this.textBoxmotd.Size = new System.Drawing.Size(205, 20);
            this.textBoxmotd.TabIndex = 20;
            this.textBoxmotd.TextChanged += new System.EventHandler(this.textBoxmotd_TextChanged);
            // 
            // buttonAddVotes
            // 
            this.buttonAddVotes.Location = new System.Drawing.Point(16, 597);
            this.buttonAddVotes.Name = "buttonAddVotes";
            this.buttonAddVotes.Size = new System.Drawing.Size(93, 39);
            this.buttonAddVotes.TabIndex = 21;
            this.buttonAddVotes.Text = "Additional Configuration";
            this.buttonAddVotes.UseVisualStyleBackColor = true;
            this.buttonAddVotes.Click += new System.EventHandler(this.buttonAddVotes_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 523);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxPassword.TabIndex = 22;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // checkBoxTestDDrace
            // 
            this.checkBoxTestDDrace.AutoSize = true;
            this.checkBoxTestDDrace.Location = new System.Drawing.Point(228, 138);
            this.checkBoxTestDDrace.Name = "checkBoxTestDDrace";
            this.checkBoxTestDDrace.Size = new System.Drawing.Size(128, 17);
            this.checkBoxTestDDrace.TabIndex = 23;
            this.checkBoxTestDDrace.Text = "Enable Test DDRace";
            this.checkBoxTestDDrace.UseVisualStyleBackColor = true;
            this.checkBoxTestDDrace.CheckedChanged += new System.EventHandler(this.checkBoxTestDDrace_CheckedChanged);
            // 
            // checkBoxRegisterServer
            // 
            this.checkBoxRegisterServer.AutoSize = true;
            this.checkBoxRegisterServer.Checked = true;
            this.checkBoxRegisterServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRegisterServer.Location = new System.Drawing.Point(228, 162);
            this.checkBoxRegisterServer.Name = "checkBoxRegisterServer";
            this.checkBoxRegisterServer.Size = new System.Drawing.Size(137, 17);
            this.checkBoxRegisterServer.TabIndex = 24;
            this.checkBoxRegisterServer.Text = "Register Server (Public)";
            this.checkBoxRegisterServer.UseVisualStyleBackColor = true;
            this.checkBoxRegisterServer.CheckedChanged += new System.EventHandler(this.checkBoxRegisterServer_CheckedChanged);
            // 
            // checkBoxTournamentMode
            // 
            this.checkBoxTournamentMode.AutoSize = true;
            this.checkBoxTournamentMode.Location = new System.Drawing.Point(228, 181);
            this.checkBoxTournamentMode.Name = "checkBoxTournamentMode";
            this.checkBoxTournamentMode.Size = new System.Drawing.Size(113, 17);
            this.checkBoxTournamentMode.TabIndex = 25;
            this.checkBoxTournamentMode.Text = "Tournament Mode";
            this.checkBoxTournamentMode.UseVisualStyleBackColor = true;
            this.checkBoxTournamentMode.CheckedChanged += new System.EventHandler(this.checkBoxTournamentMode_CheckedChanged);
            // 
            // checkBoxPausable
            // 
            this.checkBoxPausable.AutoSize = true;
            this.checkBoxPausable.Location = new System.Drawing.Point(228, 202);
            this.checkBoxPausable.Name = "checkBoxPausable";
            this.checkBoxPausable.Size = new System.Drawing.Size(107, 17);
            this.checkBoxPausable.TabIndex = 26;
            this.checkBoxPausable.Text = "Pausable (/spec)";
            this.checkBoxPausable.UseVisualStyleBackColor = true;
            this.checkBoxPausable.CheckedChanged += new System.EventHandler(this.checkBoxPausable_CheckedChanged);
            // 
            // checkBoxRescue
            // 
            this.checkBoxRescue.AutoSize = true;
            this.checkBoxRescue.Location = new System.Drawing.Point(228, 226);
            this.checkBoxRescue.Name = "checkBoxRescue";
            this.checkBoxRescue.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRescue.TabIndex = 27;
            this.checkBoxRescue.Text = "Rescue (/r)";
            this.checkBoxRescue.UseVisualStyleBackColor = true;
            this.checkBoxRescue.CheckedChanged += new System.EventHandler(this.checkBoxRescue_CheckedChanged);
            // 
            // checkBoxRankCheats
            // 
            this.checkBoxRankCheats.AutoSize = true;
            this.checkBoxRankCheats.Location = new System.Drawing.Point(228, 249);
            this.checkBoxRankCheats.Name = "checkBoxRankCheats";
            this.checkBoxRankCheats.Size = new System.Drawing.Size(123, 17);
            this.checkBoxRankCheats.TabIndex = 28;
            this.checkBoxRankCheats.Text = "Rank Cheats (Rcon)";
            this.checkBoxRankCheats.UseVisualStyleBackColor = true;
            this.checkBoxRankCheats.CheckedChanged += new System.EventHandler(this.checkBoxRankCheats_CheckedChanged);
            // 
            // DDNet
            // 
            this.ClientSize = new System.Drawing.Size(465, 648);
            this.Controls.Add(this.checkBoxRankCheats);
            this.Controls.Add(this.checkBoxRescue);
            this.Controls.Add(this.checkBoxPausable);
            this.Controls.Add(this.checkBoxTournamentMode);
            this.Controls.Add(this.checkBoxRegisterServer);
            this.Controls.Add(this.checkBoxTestDDrace);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonAddVotes);
            this.Controls.Add(this.textBoxmotd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxWelcomeMessage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBoxHelperPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxModPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxEnablePassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxMapName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAdminRconPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxServerPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DDNet";
            this.Text = "DDNet Server GUI - by Ryozuki";
            this.Load += new System.EventHandler(this.DDNet_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRcon;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdminRconPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMapName;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxEnablePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxModPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHelperPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWelcomeMessage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxmotd;
        private System.Windows.Forms.Button buttonAddVotes;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxTestDDrace;
        private System.Windows.Forms.CheckBox checkBoxRegisterServer;
        private System.Windows.Forms.CheckBox checkBoxTournamentMode;
        private System.Windows.Forms.CheckBox checkBoxPausable;
        private System.Windows.Forms.CheckBox checkBoxRescue;
        private System.Windows.Forms.CheckBox checkBoxRankCheats;
    }
}

