using System.Drawing;
using System.Windows.Forms;

namespace Self_Learn
{
    public partial class HomePage : UserControl
    {
        private int imageCounter = 0;
        public HomePage()
        {
            InitializeComponent();
            slidingTimer.Enabled = true;
        }
        private void SlidingTimer_Tick(object sender, System.EventArgs e)
        {
            ImageSlider();
        }
        private void ImageSlider()
        {
            PictureBox.BackgroundImage = null;
            if (imageCounter == 4)
            {
                imageCounter = 0;
                PictureBox.BackgroundImage = Properties.Resources.tree;
            }
            else
            {
                Image[] slidingImages = new Image[4];
                slidingImages[0] = Properties.Resources.tree;
                slidingImages[1] = Properties.Resources.homePic1;
                slidingImages[2] = Properties.Resources.homePic2;
                slidingImages[3] = Properties.Resources.homePic3;
                PictureBox.BackgroundImage = slidingImages[imageCounter];
            }
            imageCounter++;
        }
    }
}
