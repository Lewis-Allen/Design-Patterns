using System.Drawing;
using System.Windows.Forms;

namespace ProxyPattern
{
    internal class RealImage : IImage
    {
        private string FileName;
        private Image image;
        public RealImage(string FileName)
        {
            this.FileName = FileName;
            LoadImageFromDisk();
        }
        public void LoadImageFromDisk()
        {
            image = Image.FromFile(FileName);
            image = new Bitmap(image, new Size(528, 297));
        }

        public void DisplayImage(PictureBox pictureBox1)
        {
            pictureBox1.Image = image;
        }   
    }
}