using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class DDNet : Form
    {
        public DDNet()
        {
            InitializeComponent();
        }

        string textdef;

        string servername = "My DDNet Server";
        int serverport = 8303;
        string adminrcon = "";
        string modrcon = "";
        string helperrcon = "";
        string mapname = "Kobra 4";
        string password = "";
        bool enablepassword = false;
        bool enabletestddrace = false;
        bool registerserver = true;
        bool tournmode = false;
        bool pausable = false;
        bool rescue = false;
        bool rankcheats = false;
        string welcomemessage = "";
        string promptValue;
        string motd = "";

        private void buttonAddVotes_Click(object sender, EventArgs e)
        {
            promptValue = Prompt.ShowDialog("Configuration:", "Additional Configuration", textdef);
            textdef = promptValue;
        }

        private void DDNet_Load_1(object sender, EventArgs e)
        {
            textdef = "";
        }

        private void textBoxServerName_TextChanged(object sender, EventArgs e)
        {
            servername = textBoxServerName.Text;
        }

        private void textBoxServerPort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                serverport = Int32.Parse(textBoxServerPort.Text);
            }
            catch
            {
                MessageBox.Show("Server Port must be a number", "Server Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAdminRconPassword_TextChanged(object sender, EventArgs e)
        {
            adminrcon = textBoxAdminRconPassword.Text;
        }

        private void maskedTextBoxModPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            modrcon = maskedTextBoxModPassword.Text;
        }

        private void maskedTextBoxHelperPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            helperrcon = maskedTextBoxHelperPassword.Text;
        }

        private void textBoxMapName_TextChanged(object sender, EventArgs e)
        {
            mapname = textBoxMapName.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
        }

        private void checkBoxEnablePassword_CheckedChanged(object sender, EventArgs e)
        {
            enablepassword = checkBoxEnablePassword.Checked;
        }

        private void checkBoxTestDDrace_CheckedChanged(object sender, EventArgs e)
        {
            enabletestddrace = checkBoxTestDDrace.Checked;
        }

        private void checkBoxRegisterServer_CheckedChanged(object sender, EventArgs e)
        {
            registerserver = checkBoxRegisterServer.Checked;
        }

        private void checkBoxTournamentMode_CheckedChanged(object sender, EventArgs e)
        {
            tournmode = checkBoxTournamentMode.Checked;
        }

        private void checkBoxPausable_CheckedChanged(object sender, EventArgs e)
        {
            pausable = checkBoxPausable.Checked;
        }

        private void checkBoxRescue_CheckedChanged(object sender, EventArgs e)
        {
            rescue = checkBoxRescue.Checked;
        }

        private void checkBoxRankCheats_CheckedChanged(object sender, EventArgs e)
        {
            rankcheats = checkBoxRankCheats.Checked;
        }

        private void textBoxWelcomeMessage_TextChanged(object sender, EventArgs e)
        {
            welcomemessage = textBoxWelcomeMessage.Text;
        }

        private void textBoxmotd_TextChanged(object sender, EventArgs e)
        {
            motd = textBoxmotd.Text;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string stringservername = "sv_name \"" + servername + "\"";
            string stringserverport = "sv_port " + serverport.ToString();
            string stringadminrcon = "sv_rcon_password \"" + adminrcon + "\"";
            string stringmodrcon = "sv_rcon_mod_password \"" + modrcon + "\"";
            string stringhelperrcon = "sv_rcon_helper_password \"" + helperrcon + "\"";
            string stringmapnae = "sv_map \"" + mapname + "\"";
            string stringpassword;
            string stringtestddrace;
            string stringregisterserver;
            string stringtournmode;
            string stringpausable;
            string stringrescue;
            string stringrankcheats;
            string stringwelcomemessage = "sv_welcome \"" + welcomemessage + "\"";
            string stringmotd = "sv_motd \"" + motd + "\"";

            #region lotofifs
            if (enablepassword)
            {
                stringpassword = "";
            }
            else
            {
                stringpassword = "password \"" + password + "\"";
            }

            if (enabletestddrace)
            {
                stringtestddrace = "sv_test_cmds 1";
            }
            else
            {
                stringtestddrace = "sv_test_cmds 0";
            }

            if (registerserver)
            {
                stringregisterserver = "sv_register 1";
            }
            else
            {
                stringregisterserver = "sv_register 0";
            }

            if (tournmode)
            {
                stringtournmode = "sv_tournament_mode 1";
            }
            else
            {
                stringtournmode = "sv_tournament_mode 0";
            }

            if (pausable)
            {
                stringpausable = "sv_pauseable 1";
            }
            else
            {
                stringpausable = "sv_pauseable 0";
            }

            if (rescue)
            {
                stringrescue = "sv_rescue 1";
            }
            else
            {
                stringrescue = "sv_rescue 0";
            }

            if (rankcheats)
            {
                stringrankcheats = "sv_rank_cheats 1";
            }
            else
            {
                stringrankcheats = "sv_rank_cheats 0";
            }
            #endregion

            string[] additionallines;

            if (String.IsNullOrEmpty(textdef))
            {
                #region deftext
                string deftext = "add_vote \"Map: Kobra 4\" \"change_map \\\"Kobra 4\\\"\"" + Environment.NewLine +
                                "add_vote \"Map: Goo!\" \"change_map Goo!\"\n" + Environment.NewLine +
                                "add_vote \" \" \"info\"\n" + Environment.NewLine +
                                "add_vote \"Option: Normal gravity\" \"tune gravity 0.50\"" + Environment.NewLine +
                                "add_vote \"Option: Moon gravity\" \"tune gravity 0.25\"" + Environment.NewLine +
                                "add_vote \"Option: No gravity\" \"tune gravity 0.00\"" + Environment.NewLine +
                                "add_vote \"  \" \"info\"\n" + Environment.NewLine +
                                "add_vote \"Option: Reset server\" \"exec autoexec_server.cfg\"" + Environment.NewLine +
                                "add_vote \"Option: Shutdown server\" \"shutdown\"" + Environment.NewLine + Environment.NewLine +
                                "# Non-default commands to which moderators and helpers will have access (only if testddrace is enabled)" + Environment.NewLine +
                                "access_level left 2" + Environment.NewLine +
                                "access_level right 2" + Environment.NewLine +
                                "access_level up 2" + Environment.NewLine +
                                "access_level down 2" + Environment.NewLine +
                                "access_level super 2" + Environment.NewLine +
                                "access_level unsuper 2" + Environment.NewLine +
                                "access_level tele 2" + Environment.NewLine +
                                "access_level totele 2" + Environment.NewLine +
                                "access_level totelecp 2" + Environment.NewLine +
                                "access_level logout 2" + Environment.NewLine +
                                "access_level ninja 2" + Environment.NewLine +
                                "access_level grenade 2" + Environment.NewLine +
                                "access_level shotgun 2" + Environment.NewLine +
                                "access_level rifle 2" + Environment.NewLine +
                                "access_level weapons 2" + Environment.NewLine +
                                "access_level unweapons 2" + Environment.NewLine +
                                "access_level unrifle 2" + Environment.NewLine +
                                "access_level unshotgun 2" + Environment.NewLine +
                                "access_level ungrenade 2" + Environment.NewLine +
                                "access_level unsolo 2" + Environment.NewLine +
                                "access_level undeep 2" + Environment.NewLine +
                                "access_level status 2" + Environment.NewLine + Environment.NewLine +
                                "# commands for moderators only" + Environment.NewLine +
                                "access_level ban 1" + Environment.NewLine +
                                "access_level unban 1" + Environment.NewLine +
                                "access_level ban_range 1" + Environment.NewLine +
                                "access_level unban_range 1" + Environment.NewLine +
                                "access_level unban_all 1" + Environment.NewLine +
                                "access_level bans 1" + Environment.NewLine +
                                "access_level bans_save 1" + Environment.NewLine +
                                "access_level kick 1" + Environment.NewLine +
                                "access_level force_vote 1";
                #endregion deftext

                additionallines = deftext.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            }
            else
            {
                additionallines = textdef.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            }

            string[] lines = {stringservername, stringserverport, stringadminrcon, stringmodrcon, stringhelperrcon, stringmapnae, stringpassword, stringtestddrace, stringregisterserver,
            stringtournmode, stringpausable, stringrescue, stringrankcheats, stringwelcomemessage, stringmotd};
            lines = lines.Concat(additionallines).ToArray();
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "//autoexec_server.cfg", lines);
        }
    }
}
