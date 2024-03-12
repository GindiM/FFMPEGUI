using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FFMPEGUI
{
    public partial class Form1 : Form
    {
        //public static readonly string pathToProcess = "C:\\Users\\VVS\\Desktop\\f\\ffmpeg.exe"; //temp debug path
        public static readonly string pathToProcess = Path.Combine(Directory.GetCurrentDirectory().ToString(), "ffmpeg.exe");



        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetToolTips(
                (numericUpDown_trimStartHours, "Hr"),
                (numericUpDown_trimStartMinuets, "Min"),
                (numericUpDown_trimStartSeconds, "Sec"),
                (numericUpDown_trimEndHours, "Hr"),
                (numericUpDown_trimEndMinuets, "Min"),
                (numericUpDown_trimEndSeconds, "Sec")
                );
        }

        static void SetToolTips(params (Control, string)[] ItemTooltipText)
        {
            ToolTip tt = new ToolTip();

            for (int i = 0; i < ItemTooltipText.Length; i++)
            {
                if (ItemTooltipText[i].Item1 == null || string.IsNullOrEmpty(ItemTooltipText[i].Item2))
                {
                    continue;
                }
                tt.SetToolTip(ItemTooltipText[i].Item1, ItemTooltipText[i].Item2);
            }

        }
        static void RunVideoConvertion(string sourceFile, string outputFormat, string trimStart, string trimEnd, string outputFolder)
        {
            string ss = "-ss ";
            string to = " -to ";
            string full_Trim_String;

            if (string.IsNullOrEmpty(trimStart) || string.IsNullOrEmpty(trimEnd))
            {
                ss = string.Empty;
                to = string.Empty;
                trimStart = string.Empty;
                trimEnd = string.Empty;
            }

            if (trimEnd == "00:00:00")
            {
                to = "";
                trimEnd = "";
            }


            full_Trim_String = $"{ss}{trimStart}{to}{trimEnd}";



            if (outputFolder == null || outputFolder.Length == 0)
            {
                outputFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            //string allowAllProtocols = "-protocol_whitelist \"all\"";

            string final = $"-i {sourceFile} {full_Trim_String} -c copy {outputFolder}\\output.{outputFormat}";

            MessageBox.Show(final);

            ProcessStart.StartExternalProcess(pathToProcess, final);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose a video file";
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.flv;*.mkv;*.mov;*.wmv;*.mpeg;*.mpg;*.3gp;*.vob;*.ts;*.m2ts;*.ogg;*.asf;*.rm;*.swf;*.mxf;*.nut|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_URI.Text = openFileDialog.FileName;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string trimStart = null;
            string trimEnd = null;

            if (checkBox_trim.Checked)
            {
                trimStart = $"{numericUpDown_trimStartHours.Value.ToString().PadLeft(2, '0')}:{numericUpDown_trimStartMinuets.Value.ToString().PadLeft(2, '0')}:{numericUpDown_trimStartSeconds.Value.ToString().PadLeft(2, '0')}";
                trimEnd = $"{numericUpDown_trimEndHours.Value.ToString().PadLeft(2, '0')}:{numericUpDown_trimEndMinuets.Value.ToString().PadLeft(2, '0')}:{numericUpDown_trimEndSeconds.Value.ToString().PadLeft(2, '0')}";

            }

            RunVideoConvertion(textBox_URI.Text, comboBox1.SelectedItem.ToString(), trimStart, trimEnd, null);
        }

        private void button_m3u8_Click(object sender, EventArgs e)
        {
            string m3u8link = textbox_m3u8.Text;
            m3u8link = m3u8link.Trim();
            textbox_m3u8.Text = m3u8link;

            if (!m3u8link.EndsWith(".m3u8"))
            {
                MessageBox.Show("Source's format has to be .m3u8");
                return;
            }
            RunVideoConvertion(m3u8link, comboBox2.SelectedItem.ToString(), null, null, null);

            //working string debug
            //string test = $"-i https://cfvod.kaltura.com/hls/p/2717431/sp/271743100/serveFlavor/entryId/1_4a6kir7n/v/11/ev/12/flavorId/1_3dcarn1b/name/a.mp4/index.m3u8 -c copy {Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\.output.mp4";
            //ProcessStart.StartExternalProcess(pathToProcess, test);


        }


    }
}
