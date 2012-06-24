using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PhotoResizer
{
    public partial class Form1 : Form
    {
        string srcFolder;
        string destFolder;
        int largeSize;
        int smallSize;
        string userFileNameChoice;
        string htmlCode;

        public static readonly List<string> AcceptedExtensions = new List<string> { ".jpg", ".png" };

        public Form1()
        {
            InitializeComponent();
        }

        private void srcSelectFolder_Click(object sender, EventArgs e)
        {
            srcFolderBrowserDialog.ShowDialog();
            srcFolderPath.Text = srcFolderBrowserDialog.SelectedPath;
        }

        private void destSelectFolder_Click(object sender, EventArgs e)
        {
            destFolderBrowserDialog.ShowDialog();
            destFolderPath.Text = destFolderBrowserDialog.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workingLbl.Visible = true;

            srcFolder = srcFolderPath.Text;
            destFolder = destFolderPath.Text;
            largeSize = Convert.ToInt32(longSize.Text);
            smallSize = Convert.ToInt32(thumbSize.Text);
            userFileNameChoice = userFileName.Text;

            resizeAllPicturesInSrcFolder();

            htmlCodeTxt.Text = htmlCode;

            htmlCode = "";

            workingLbl.Visible = false;
        }

        private void resizeAllPicturesInSrcFolder()
        {
            string errMessage = "";

            //check directories exist
            if (!Directory.Exists(srcFolder))
            {
                errMessage += "Source folder does not exist.\n";
            }
            if (!Directory.Exists(destFolder))
            {
                errMessage += "Destination folder does not exist.";
            }

            if (errMessage.Length != 0)
            {
                MessageBox.Show(errMessage);
                return;
            }

            int i = 1;

            //source and destination folders exist, so go through all pictures in the folder ignoring subfolders
            foreach (string file in Directory.GetFiles(srcFolder))
            {
                //if file is an image file in one of the acceptable formats, resize
                if (AcceptedExtensions.Contains(Path.GetExtension(file).ToLower()))
                {
                    resize(file, userFileNameChoice + "-" + i + Path.GetExtension(file), userFileNameChoice + "-" + i + "_t" + Path.GetExtension(file), alt.Text+" "+i);
                }
                i++;
            }
        }

        private void resize(string fileName, string newFileName, string newThumbName, string altText)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(fileName);
            System.Drawing.Image smallImage;
            System.Drawing.Image thumbnail;

            int heightSmall;
            int widthSmall;

            int heightThumb;
            int widthThumb;
            
            //determine the long side of the image
            if (originalImage.Width < originalImage.Height)
            {
                heightSmall = largeSize;
                widthSmall = originalImage.Width * heightSmall / originalImage.Height;

                heightThumb = smallSize;
                widthThumb = originalImage.Width * heightThumb / originalImage.Height;
            }
            else
            {
                widthSmall = largeSize;
                heightSmall = originalImage.Height * widthSmall / originalImage.Width;

                widthThumb = smallSize;
                heightThumb = originalImage.Height * widthThumb / originalImage.Width;
            }

            //resize the long side of the image to create newly sized image
            Size s = new Size(widthSmall, heightSmall);
            smallImage = resizeToSmallImage(originalImage, s);

            //resize the long side of the image to create newly sized thumbnail
            thumbnail = originalImage.GetThumbnailImage(widthThumb, heightThumb, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            originalImage.Dispose();

            //save image in new destination as regular sized image
            smallImage.Save(destFolder + "//" + newFileName);
            //save image in new destination as thumb image
            thumbnail.Save(destFolder + "//" + newThumbName);

            //generate html code
            htmlCode += "<a href=\""+newFileName+"\"><img src=\""+newThumbName+"\" width="+widthThumb+" height="+heightThumb+" alt=\""+altText+"\"></a>\n";
        }

        //this method courtesy http://www.switchonthecode.com/tutorials/csharp-tutorial-image-editing-saving-cropping-and-resizing
        private static Image resizeToSmallImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void htmlCodeTxt_Click(object sender, EventArgs e)
        {
            htmlCodeTxt.SelectAll();
        }
    }
}
