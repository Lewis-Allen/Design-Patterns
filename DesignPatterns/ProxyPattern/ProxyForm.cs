
using System;
using System.IO;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class ProxyForm : Form
    {
        RealImage RealImage1;
        IImage ProxyImage2;
        IImage ProxyImage3;
        IImage ProxyImage4;
        private static string FolderPath = @"res" + Path.DirectorySeparatorChar;

        public ProxyForm()
        {
            InitializeComponent();

            RealImage1 = new RealImage(FolderPath + @"Image1.jpg");
            ProxyImage2 = new ProxyImage(FolderPath + @"Image2.jpg");
            ProxyImage3 = new ProxyImage(FolderPath + @"Image3.jpg");
            ProxyImage4 = new ProxyImage(FolderPath + @"Image4.jpg");

            RealImage1.LoadImageFromDisk(); // Image is already loaded on construction and may never be displayed
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            RealImage1.DisplayImage(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProxyImage2.DisplayImage(pictureBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProxyImage3.DisplayImage(pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProxyImage4.DisplayImage(pictureBox1);
        }
    }
}
