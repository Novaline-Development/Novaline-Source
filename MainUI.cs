using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;

namespace Novaline
{
    public partial class MainUI : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public MainUI()
        {
            InitializeComponent();
            try
            {
                listBox1.Items.Clear();//Clear Items in the LuaScriptList
                Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
                Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
            }
            catch
            {
                string message = "Script folder was not found, make sure you have a folder called 'Scripts' in the same directory as me.";
                string title = "Novaline";
                MessageBox.Show(message, title);
            }
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string message = "I'm sorry for the 2 links that are about to open. These open because I haven't coded an api yet. I will do this very soon tho!";
            string title = "Novaline";
            MessageBox.Show(message, title);
            module.LaunchExploit();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open Script";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                process.Kill();
            }
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();//Clear Items in the LuaScriptList
                Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
                Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
            }
            catch
            {
                string message = "Script folder was not found, make sure you have a folder called 'Scripts' in the same directory as me.";
                string title = "Novaline";
                MessageBox.Show(message, title);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            ScriptHub openform = new ScriptHub();
            openform.Show();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }
    }
}
