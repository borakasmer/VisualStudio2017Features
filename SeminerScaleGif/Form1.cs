using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminerScaleGif
{
    public partial class Form1 : Form
    {
        public string fileName { get; set; }
        public String[] SizeArray { get; set; } = new String[] { "100x100", "200x200", "300x300", "400x400", "500x500" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Gif files (*.gif)|*.gif|Png Files (*.png)|*.png";
            openFileDialog1.InitialDirectory = @"c:\gif2";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog1.FileName;
                    pictureBox1.Load(fileName);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(txtWidth.Text, out int widthInt);
            int.TryParse(txtHeight.Text, out int heightInt);
            IFType type;
            if (rdGif.Checked)
            {
                type = new Gif() { Width = widthInt, Height = heightInt, GifName = "" };
            }
            else
            {
                type = new Image() { Width = widthInt, Height = heightInt, ImageName = "" };
            }
            //var result = ScaleImage(type);
            try
            {
                (var boolResult, string flName) = ScaleImage(type);

                //(bool boolResult,string fileName) ScaleImage(IFType fileType)
                (bool boolResult, string flName) ScaleImage(IFType fileType)
                {
                    try
                    {
 //                       throw new DivideByZeroException();
                        switch (fileType)
                        {
                            case Gif t:
                                {
                                    using (MagickImageCollection collection = new MagickImageCollection(fileName))
                                    {
                                        collection.Coalesce();
                                        MagickGeometry size = new MagickGeometry(t.Width, t.Height);
                                        size.IgnoreAspectRatio = false;

                                        foreach (MagickImage image in collection)
                                        {
                                            image.Resize(size);
                                        }
                                        //string folderName = Path.GetFileName(Path.GetDirectoryName(fileName));
                                        //string gifName = folderName + "\\" + Path.GetFileNameWithoutExtension(fileName) + t.Width + "x" + t.Height + ".gif";
                                        string gifName = GetFileName(t);
                                        collection.Write(gifName);

                                        return (true, gifName);
                                    }
                                    break;
                                }

                            case Image t:
                                {
                                    using (MagickImage image = new MagickImage(fileName))
                                    {
                                        MagickGeometry size = new MagickGeometry(t.Width, t.Height);
                                        size.IgnoreAspectRatio = false;
                                        image.Resize(size);
                                        string imageName = GetFileName(t);
                                        image.Write(imageName);

                                        return (true, imageName);
                                        break;
                                    }
                                }
                        }

                        return (true, "");
                    }
                    catch
                    {
                        return (false, "");
                    }
                    return (false, "");
                }

                string GetFileName(IFType TypeFil)
                {
                    switch (TypeFil)
                    {
                        case Gif t:
                            {
                                //string folderName = Path.GetFileName(Path.GetDirectoryName(fileName));
                                //string gifName = folderName + "\\" + Path.GetFileNameWithoutExtension(fileName) + t.Width + "x" + t.Height + ".gif";
                                string gifName = "c:\\Gif2\\" + Path.GetFileNameWithoutExtension(fileName) + t.Width + "x" + t.Height + ".gif";
                                return gifName;
                                break;
                            }
                        case Image t:
                            {
                                //string folderName = Path.GetFileName(Path.GetDirectoryName(fileName));
                                //string imageName = folderName + "\\" + Path.GetFileNameWithoutExtension(fileName) + t.Width + "x" + t.Height + ".png";
                                string imageName = "c:\\Gif2\\" + Path.GetFileNameWithoutExtension(fileName) + t.Width + "x" + t.Height + ".png";
                                return imageName;
                                break;
                            }
                    }
                    return "";
                }

                //pictureBox1.Load(result.fileName);
                pictureBox1.Load(flName);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rowNum = rnd.Next(1, 5);
            ref string size = ref GetRandomSize(rowNum);
            rndWidth.Text = size.Split('x')[0];
            rndHeight.Text = size.Split('x')[1];

            size = "121x17";

            MessageBox.Show(SizeArray[rowNum]);

            ref string GetRandomSize(int rowNumber)
            {
                return ref SizeArray[rowNumber];
            }

            /*
            private void button3Impossible_Click(object sender, EventArgs e)
            {
                Random rnd = new Random();
                int rowNum = rnd.Next(1, 5);
                //(ref string size,int width,int height) = (ref,,) GetRandomSizeImpossible(rowNum);
                (ref string resize, int width, int height) = ref GetRandomSizeImpossible(rowNum);

                resize = rndWidth.Text+"x" + rndHeight.Text;
                MessageBox.Show(SizeArray[rowNum]);               

                (ref string, int width, int height) GetRandomSizeImpossible(int rowNumber)
                {
                    int.TryParse(SizeArray[rowNumber].Split('x')[0], out int w);
                    int.TryParse(SizeArray[rowNumber].Split('x')[1], out int h);

                    return (ref SizeArray[rowNumber], w, h);
            }
            */
        }
    }
}

interface IFType
{
    int Width { get; set; }
    int Height { get; set; }
}

public class Image : IFType
{
    public int Width { get; set; }
    public int Height { get; set; }

    public string ImageName { get; set; }
}

public class Gif : IFType
{
    public int Width { get; set; }
    public int Height { get; set; }

    public string GifName { get; set; }
}
