
using System;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class ProxyForm : Form
    {
        RealImage RealImage1;
        IImage ProxyImage2;
        IImage ProxyImage3;
        IImage ProxyImage4;
        public ProxyForm()
        {
            InitializeComponent();

            RealImage1 = new RealImage(@"res\Image1.jpg");
            ProxyImage2 = new ProxyImage(@"res\Image2.jpg");
            ProxyImage3 = new ProxyImage(@"res\Image3.jpg");
            ProxyImage4 = new ProxyImage(@"res\Image4.jpg");

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
