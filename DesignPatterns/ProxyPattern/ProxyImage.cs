using System.Windows.Forms;

namespace ProxyPattern
{
    class ProxyImage : IImage
    {
        private string FileName { get; set; }
        private IImage RealImage { get; set; }

        public ProxyImage(string FileName)
        {
            this.FileName = FileName;
        }
        public void DisplayImage(PictureBox pictureBox1)
        {
            if(RealImage == null)
            {
                RealImage = new RealImage(FileName);
            }
            RealImage.DisplayImage(pictureBox1);
        }
    }
}
