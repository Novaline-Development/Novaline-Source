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

namespace Novaline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string message = "Thanks for clicking me! :D";
            string title = "Novaline";
            MessageBox.Show(message, title);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/frYZvzJygY");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://link-to.net/153633/novalinekey");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            String gettext = siticoneMaterialTextBox1.Text;
            int gettext_amount = gettext.Length;

            WebClient wc = new WebClient();
            string ks = wc.DownloadString("https://pastebin.com/raw/hyCuXAEp");
            if (ks == "outdated")
            {
                string message = "Oops, looks like your Novaline verion in outdated. Please download the new version from our discord in the #download channel!";
                string title = "Novaline";
                MessageBox.Show(message, title);
                System.Diagnostics.Process.Start("https://discord.gg/frYZvzJygY");
            }
            else
            {
                if (gettext_amount == 0)
                {
                    string message = "Invalid key, please try again!";
                    string title = "Novaline";
                    MessageBox.Show(message, title);
                }
                else
                {
                    if (ks.Contains(siticoneMaterialTextBox1.Text))
                    {
                        string message = "Valid key, thank you for choosing Novaline!";
                        string title = "Novaline";
                        MessageBox.Show(message, title);
                        this.Hide();
                        MainUI mainui = new MainUI();
                        mainui.Show();
                    }
                    else
                    {
                        string message = "Invalid key, please try again!";
                        string title = "Novaline";
                        MessageBox.Show(message, title);
                    }
                }
            }
        }
    }
}
