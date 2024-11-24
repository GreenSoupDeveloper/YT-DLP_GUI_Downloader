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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string filepath = "tools/yt-dlp.exe";
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(ffmpegdown);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe"), filepath);
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void ffmpegdown(object sender, EventArgs e) {
            label1.Text = "Downloading ffmpeg..";
            string filepath = "tools/ffmpeg.exe";
            WebClient web = new WebClient();
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            web.DownloadFileAsync(new Uri("https://download1532.mediafire.com/z12ghyri0bagnCOz2WT5oqVeq2Asm49j4b8gtjvr90ZoshX3JlHqzKQ1KKc_PuZGKP0pG-yhNHj5h8GFw5gX3BuKkLs9X5se4GYtQGYiUxitLLyca9gBDRyBb8p9feJL11NmwLUeZ1w-JyXLigQtud7CNsFzV1L7QFrnz6kAnfnOYA/p3pq1sheru7k78x/ffmpeg.exe"), filepath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
