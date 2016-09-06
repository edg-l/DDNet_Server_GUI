using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string textdef)
        {
            Form prompt = new Form()
            {
                Width = 450,
                Height = 525,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 40, Width = 400, Height = 400 };
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;

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

            if (textdef == "")
            {     
                textBox.Text = deftext;
            }
            else
            {
                textBox.Text = textdef;
            }

            Button confirmation = new Button() { Text = "Save", Left = 20, Width = 100, Height = 30, Top = 450, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            Button resetodef = new Button() { Text = "Reset", Left = 140, Width = 100, Height = 30, Top = 450, DialogResult = DialogResult.OK };
            resetodef.Click += (sender, e) => { textBox.Text = deftext; };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(resetodef);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
