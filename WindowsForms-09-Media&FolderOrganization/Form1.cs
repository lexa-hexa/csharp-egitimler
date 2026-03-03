using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_09_Media_FolderOrganization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seçiniz";
            //openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Klasör seçiniz";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text += " " + folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
