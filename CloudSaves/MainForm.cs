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

namespace CloudSaves
{
    public partial class Form1 : Form
    {
        private Array settings = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\config\\");

        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) {
            foreach (string save in this.settings) {
                DataGridViewRow row = (DataGridViewRow)configDataGridView.RowTemplate.Clone();
                row.CreateCells(configDataGridView, Path.GetFileNameWithoutExtension(save));
                configDataGridView.Rows.Add(row);
            }
        }

        private void SyncSaveButton_Click(object sender, EventArgs e)
        {
            SaveManager.Sync();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ConfigForm form = new ConfigForm();
            form.ShowDialog();
        }
    }
}
