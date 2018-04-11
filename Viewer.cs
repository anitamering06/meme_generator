using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeGenerator
{
    public partial class Viewer : Form
    {
        private string imagesPath = AppDomain.CurrentDomain.BaseDirectory + @"Images\";
        private int index = 0;
        private List<string> images;
        
        


        public Viewer()
        {
            InitializeComponent();
            GetAllImages(imagesPath);
            SetImage(index);

        }

        private void Viewer_Load(object sender, EventArgs e)
        {

        }

        void SetImage(int i)
        {
            if (images?.Count > i)
            {
                var path = images[i];
                var img = Image.FromFile(imagesPath + path);
                double aspect = 1;
                int width = img.Width;
                int height = img.Height;
                aspect = (double)width / (double)height;
                if (width > height)
                {

                    width = preview.Width;
                    height = (int)(width / aspect);
                    if (height > preview.Height)
                    {
                        height = preview.Height;
                        width = (int)(height * aspect);
                    }
                }
                else
                {
                    aspect = (double)height / (double)width;
                    height = preview.Height;
                    width = (int)(height / aspect);
                    if (width > preview.Width)
                    {
                        width = preview.Width;
                        height = (int)(width * aspect);
                    }
                }

                img = ResizeImage(img, width, height);
                preview.Image = img;
            }
        }

        void GetAllImages(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            images = new List<string>();
            d.GetFiles().ToList().ForEach(x => images.Add(x.Name));
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index = index > 0 ? index - 1 : images.Count - 1;
            SetImage(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index = index < images.Count ? index + 1 : 0;
            SetImage(index);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            topLabel.Text = topText.Text;
            topLabel.MaximumSize = new Size(preview.Width, 200);
        }

        private void bottomText_TextChanged(object sender, EventArgs e)
        {
            bottomLabel.Text = bottomText.Text;
            bottomLabel.MaximumSize = new Size(preview.Width, 200);
        }

        private void save_Click(object sender, EventArgs e)
        {

            string firstText = topText.Text;
            string secondText = bottomText.Text;
            Bitmap bitmap = (Bitmap)Image.FromFile(imagesPath + images[index]);
            RectangleF TopSize = new RectangleF(0, 10, bitmap.Width, 400);
            RectangleF BottomSize = new RectangleF(0, bitmap.Height - 100, bitmap.Width, 400);

            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.FileName = "*";
            saveImage.DefaultExt = "bmp";
            saveImage.ValidateNames = true;
            saveImage.Filter = "Bitmap Image (.bmp)|* .bmp |JPEG Image (.jpg)|*.jpeg |Png Image (.png)|*.png;";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font memeFont = new Font("Impact", 24, FontStyle.Bold, GraphicsUnit.Point))
                    {
                        graphics.DrawString(firstText, memeFont, Brushes.White, TopSize);
                        graphics.DrawString(secondText, memeFont, Brushes.White, BottomSize);
                    }

                }
                bitmap.Save(saveImage.FileName);
            }
        }

    }
}


