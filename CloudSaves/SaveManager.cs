using System;
using System.Net;
using System.Windows.Forms;

namespace CloudSaves
{
    class SaveManager
    {
        private WebClient client;
        private string host = Properties.Settings.Default.Host;
        private string username = Properties.Settings.Default.Username;
        private string password = Properties.Settings.Default.Password;
        private string saveName = "ATWIN0000.dat";
        private string savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KoeiTecmo\\Attack on Titan\\SAVEDATA\\ATWIN0000.dat";

        public SaveManager()
        {
            this.client = new WebClient();
            this.client.Credentials = new NetworkCredential(this.username, this.password);
            this.client.BaseAddress = "ftp://" + this.host + "/";
        }

        public static void Sync() {
            MessageBox.Show("its ya boi");
        }

        private void Upload()
        {
            try
            {
                this.client.UploadFile(this.saveName, this.savePath);
                MessageBox.Show("Save uploaded successfully!");
            }
            catch
            {
                MessageBox.Show("Upload failed :(");
            }
        }

        private void Download()
        {
            try
            {
                this.client.DownloadFile(this.saveName, this.savePath);
                MessageBox.Show("Save downloaded successfully!");
            }
            catch
            {
                MessageBox.Show("Download failed :(");
            }
        }
    }
}
