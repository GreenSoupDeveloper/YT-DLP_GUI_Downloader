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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YT_DLP_GUI_Downloader
{
    public partial class ffmpegdown : Form
    {
        public ffmpegdown()
        {
            InitializeComponent();
        }

        private void ffmpegdown_Load(object sender, EventArgs e)
        {
            label1.Text = "Downloading ffmpeg..";
            string filepath = "tools/ffmpeg.exe";
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://download1532.mediafire.com/7exe1rzgrh3gnoXJgQ2swityqrE4HkIS2kKCywiuJ203Xm9_BRIXZIc6bI8sYn1vAcChoOGpw5-qtAVia6aw-UFKzZavFPzn7wpHHdyzywg2OBuXC2LRXDhgKVzCAYFyrWX9BkOZHGEF1Aan4UBKYW3xC6JtvsneuiVRjF9SuS_CMCPu/p3pq1sheru7k78x/ffmpeg.exe"), filepath);
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
        }

       
    }
}
