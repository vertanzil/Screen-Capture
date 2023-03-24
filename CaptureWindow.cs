using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Screen_Capture{
	
	public partial class CaptureWindow : Form{
		int selectX;
        int selectY;
        int selectWidth;
        int selectHeight;
        public Pen selectPen;
        bool start = false;
		public CaptureWindow(){
			InitializeComponent();
        pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
        pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
		}
        
        
        
        
        
		void CaptureWindowLoad(object sender, EventArgs e){
	        this.Hide();
            Bitmap printscreen = new Bitmap(SystemInformation.VirtualScreen.Width,
                        SystemInformation.VirtualScreen.Height);
                        Graphics graphics = Graphics.FromImage(printscreen as Image);
                        graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
                        using (MemoryStream s = new MemoryStream())
                        {
                        printscreen.Save(s, ImageFormat.Png);
                        pictureBox1.Size = new System.Drawing.Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
                        pictureBox1.Image = Image.FromStream(s);
                      }
            this.Show();
            Cursor = Cursors.Cross;
		}
        private void SaveToClipboard()
        {
            string filename = System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()) + ".png";
            if (selectWidth > 0)
            {
                Rectangle rect = new Rectangle(selectX, selectY, selectWidth, selectHeight);
                Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                Bitmap _img = new Bitmap(selectWidth, selectHeight);
                Graphics g = Graphics.FromImage(_img);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
                Clipboard.SetImage(_img);





                //Saves the fucking file
                if (Clipboard.ContainsImage() == true)
                {
                    Image image = (Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
                    image.Save(Path.GetTempPath() + filename);
                } else
                {
                    Console.WriteLine("Clipboard empty.");
                }

                //checks if the program copys images or text to the clipboard
               if (Properties.Settings.Default.sett_copymode.Equals("Link Mode")){

                    //Send file to internet
                    using (var client = new WebClient())
                    {
                        client.UploadFile("http://vertanzil.rf.gd/tFG5t4k4.php", "POST", Path.GetTempPath() + filename);
                    }

                   bool settopenurlinbrowser = Properties.Settings.Default.sett_openinbrowser;

                    Clipboard.SetText("http://vertanzil.rf.gd/i/" + filename);
                    Console.Write("Text copied");

                   if (Properties.Settings.Default.sett_openinbrowser == true)
                   {
                        Process.Start("http://vertanzil.rf.gd/i/" + filename);
                        Console.Write("URL Opened");
                    }

               }


                if (Properties.Settings.Default.sett_copymode.Equals("Image Mode")){
                    Clipboard.SetImage(_img);
                    Console.Write("Image copied");
                }

            }
        }

        void PictureBox1Click(object sender, EventArgs e){}


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e){
            if (pictureBox1.Image == null)
                return;
            if (start){
                pictureBox1.Refresh();
                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;
                pictureBox1.CreateGraphics().DrawRectangle(selectPen,
                          selectX, selectY, selectWidth, selectHeight);
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //validate when user right-click
            if (!start)
            {

                if (e.Button == System.Windows.Forms.MouseButtons.Middle)
                {
                    Close();
                } else if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    //starts coordinates for rectangle
                    selectX = e.X;
                    selectY = e.Y;
                    int width = pictureBox1.Image.Size.Width;
                    int height = pictureBox1.Image.Size.Height;

                    selectPen = new Pen(Color.Red, 1);
                    selectPen.DashStyle = DashStyle.DashDotDot;
                }
                //refresh picture box
                pictureBox1.Refresh();
                //start control variable for draw rectangle
                start = true;
            } else
            {
                //validate if there is image
                if (pictureBox1.Image == null)
                    return;
                //same functionality when mouse is over
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    pictureBox1.Refresh();
                    selectWidth = e.X - selectX;
                    selectHeight = e.Y - selectY;
                    pictureBox1.CreateGraphics().DrawRectangle(selectPen, selectX,
                             selectY, selectWidth, selectHeight);

                }
                start = false;
                SaveToClipboard();
                Close();
            }
        }








    }
}
