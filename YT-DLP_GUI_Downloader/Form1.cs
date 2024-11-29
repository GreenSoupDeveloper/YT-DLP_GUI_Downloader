using System.Diagnostics;

namespace YT_DLP_GUI_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("downloads"))
            {
                Directory.CreateDirectory("downloads");
            }
            string res = "";
            if (comboBox2.Text == "2160p (4K)")
            {
                res = "2160";
            }
            else if (comboBox2.Text == "1440p (2K)")
            {
                res = "1440";
            }
            else if (comboBox2.Text == "1080p (FHD)")
            {
                res = "1080";
            }
            else if (comboBox2.Text == "720p (HD)")
            {
                res = "720";
            }
            else if (comboBox2.Text == "480p (SD)")
            {
                res = "480";
            }
            else if (comboBox2.Text == "360p (SD)")
            {
                res = "360";
            }
            else if (comboBox2.Text == "240p (SD)")
            {
                res = "240";
            }
            else if (comboBox2.Text == "144p (SD)")
            {
                res = "144";
            }


            if (comboBox1.Text == "MP3")
                Process.Start("tools/yt-dlp.exe", "-x -f \"bestaudio/best\" --audio-quality 0 --audio-format mp3 " + textBox1.Text + " -o \"downloads\\%(title)s.%(ext)s\"");
            else if (comboBox1.Text == "M4A")
                Process.Start("tools/yt-dlp.exe", "-x -f \"bestaudio/best\" --audio-quality 0 --audio-format m4a " + textBox1.Text + " -o \"downloads\\%(title)s.%(ext)s\"");
            else if (comboBox1.Text == "FLAC")
                Process.Start("tools/yt-dlp.exe", "-x -f \"bestaudio/best\" --audio-format flac " + textBox1.Text + " -o \"downloads\\%(title)s.%(ext)s\"");
            else if (comboBox1.Text == "WAV")
                Process.Start("tools/yt-dlp.exe", "-x -f \"bestaudio/best\" --audio-format wav " + textBox1.Text + " -o \"downloads\\%(title)s.%(ext)s\"");
            else if (comboBox1.Text == "WEBM")
            {
                Process.Start("tools/yt-dlp.exe", textBox1.Text + " -S res:" + res + " -o \"downloads\\%(title)s.%(ext)s\" -i");
            }
            else if (comboBox1.Text == "MKV")
            {
                Process.Start("tools/yt-dlp.exe", textBox1.Text + " -S res:" + res + " -f \"bestvideo[ext=webm]+bestaudio[ext=m4a]/best[ext=webm]/best\" -o \"downloads\\%(title)s.%(ext)s\" -i");
            }
            else if (comboBox1.Text == "MP4")
            {
                Process.Start("tools/yt-dlp.exe", textBox1.Text + " -S res:" + res + " -f \"bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best\" -o \"downloads\\%(title)s.%(ext)s\" -i");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MP4" || comboBox1.Text == "MKV" || comboBox1.Text == "WEBM" || comboBox1.Text == "3GP")
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("tools"))
            {
                Directory.CreateDirectory("tools");
            }
            if (!File.Exists("tools/yt-dlp.exe"))
            {
                Form2 form2;
                form2 = new Form2();
                form2.Show();
                /* ffmpegdown ffmpeg;
                ffmpeg = new ffmpegdown();
                ffmpeg.Show();*/
            }
            
        }
    }
}
