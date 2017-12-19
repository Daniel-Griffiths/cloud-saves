using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSaves
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            HostTextBox.Text = Properties.Settings.Default.Host;
            UsernameTextBox.Text = Properties.Settings.Default.Username;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = HostTextBox.Text;
            Properties.Settings.Default.Username = UsernameTextBox.Text;
            Properties.Settings.Default.Password = PasswordTextBox.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings Saved Successfully!");
        }
    }
}
