using KidsGame.Data_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsGame.User_Interface
{
    public partial class FigureTransferring : Form
    {
        DataOperations dataOperations;
        public FigureTransferring(DataOperations dataOperations)
        {
            InitializeComponent();

            this.dataOperations = dataOperations;
            this.MouseMove += new MouseEventHandler(mouseEvent);
            picture.Visible = false;
        }
        private class FiguresLocation
        {
            private PictureBox figure;
            private int[] itsLocation = new int[4];
            private PictureBox[] web = new PictureBox[4];
            public bool right_plase;

            public FiguresLocation(PictureBox figure, int X, int Y, PictureBox[] web)
            {
                this.figure = figure;
                this.itsLocation = LocationRecord(X, Y);
                this.web = web;
            }

            public int[] GetLocation()
            {
                return itsLocation;
            }
            public PictureBox GetFigure()
            {
                return figure;
            }
            private int[] LocationRecord(int X, int Y)
            {
                int Z = X + figure.Size.Height,
                    C = Y + figure.Size.Width;
                int[] figureLocation = new int[4] { X, Y, Z, C };

                return figureLocation;
            }
            public int GetX()
            {
                return itsLocation[0];
            }
            public int GetY()
            {
                return itsLocation[1];
            }
        }

        private const int level = 2;
        private int time, interval = 5;
        private bool remember = false, isActive = false;
        private Dictionary<int, int> ImageCoord = new Dictionary<int, int>();
        private List<FiguresLocation> figures = new List<FiguresLocation>();
        private List<string> images = new List<string>();
        private List<Color> colors = new List<Color>();
        private object currentObject = null;

        private void FigureTransferring_Load(object sender, EventArgs e)
        {
            dataOperations.GetPictures(level, ref images, ref colors, ref ImageCoord);
            FillingOut(images);
        }
        private void mouseEvent(object sender, MouseEventArgs e)
        {
            if (currentObject != null)
            {
                isActive = true;

                currentObject.GetType().GetProperty("Location").SetValue(currentObject,
                    this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y)));
            }
        }
        private void FillingOut(List<string> Images)
        {
            int counter = 0, Y = 12, X = 0;
            foreach (var creation in Images)
            {
                var pictureBox = new PictureBox();
                var box = new PictureBox[4];
                figures.Add((GetPropertys(pictureBox, ref counter, ref box, ref Y, ref X)));
                counter++;
                X++;
            }
        }
        private FiguresLocation GetPropertys(PictureBox pictureBox, ref int counter, 
            ref PictureBox[] box, ref int Y, ref int X)
        {
            if (counter % 3 == 2)
            {
                Y += 110;
                X = 0;
            }

           pictureBox.Location = new Point(X * 110, Y);
           pictureBox.Size = new Size(100, 100);
           pictureBox.BackColor = Color.Transparent;
           pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
           pictureBox.BackgroundImage = new Bitmap(images.ElementAt(counter));
           pictureBox.MouseClick += new MouseEventHandler(picture_Click);
            this.Controls.Add(pictureBox);

                GetBox(ref box, counter);

            return (new FiguresLocation(pictureBox, ImageCoord.ElementAt(counter).Key,
                ImageCoord.ElementAt(counter).Value, box));
        }
        private PictureBox[] GetWeb(ref PictureBox pictureBox1, ref PictureBox pictureBox2,
            ref PictureBox pictureBox3, ref PictureBox pictureBox4, int counter)
        {
            pictureBox1.Size = pictureBox3.Size = new Size(100, 3);
            pictureBox2.Size = pictureBox4.Size = new Size(3, 100);

            pictureBox1.Location = pictureBox2.Location = new Point(ImageCoord.ElementAt(counter).Key,
                ImageCoord.ElementAt(counter).Value);

            pictureBox4.Location = new Point(ImageCoord.ElementAt(counter).Key + 97,
                ImageCoord.ElementAt(counter).Value);

            pictureBox3.Location = new Point(ImageCoord.ElementAt(counter).Key,
                ImageCoord.ElementAt(counter).Value + 99);

            pictureBox1.BackColor = pictureBox2.BackColor = pictureBox3.BackColor =
                pictureBox4.BackColor = Color.Black;

            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);

            PictureBox[] box = new PictureBox[4] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            return box;
        }
        private PictureBox ToFront(PictureBox picture)
        {
            picture.BringToFront();
            return picture;
        }
        private void GetBox(ref PictureBox[] box, int counter)
        {
            var pictureBox1 = new PictureBox();
            var pictureBox2 = new PictureBox();
            var pictureBox3 = new PictureBox();
            var pictureBox4 = new PictureBox();

            box = GetWeb(ref pictureBox1, ref pictureBox2, ref pictureBox3, ref pictureBox4, counter);
        }
        private bool IsInside(PictureBox figure, int[] coord)
        {
            if (coord[2] > figure.Location.X && coord[0] < figure.Location.X)
                if (coord[3] > figure.Location.Y && coord[1] < figure.Location.Y)
                    return true;
            return false;
        }
        private void picture_Click(object sender, EventArgs e)
        {
            currentObject = sender;
            ToFront((PictureBox)sender);
            if (isActive)
            {
                foreach (var figure in figures)
                {
                    if ((PictureBox)sender == figure.GetFigure())
                        if (IsInside((PictureBox)sender, figure.GetLocation()))
                        {
                            var pictureBox = (PictureBox)sender;
                            pictureBox.MouseClick -= new MouseEventHandler(picture_Click);
                            pictureBox.Location = new Point(figure.GetX(), figure.GetY());
                            figure.right_plase = true;
                        }
                }

                isActive = false;
                currentObject = null;
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            int counter = 0, Y = 12, X = 0;

            foreach (var figure in figures)
            {
                if (counter % 3 == 2)
                {
                    Y += 110;
                    X = 0;
                }

                var picture = figure.GetFigure();
                picture.Location = new Point(X * 110, Y);
                picture.MouseClick += new MouseEventHandler(picture_Click);
                figure.right_plase = false;
                counter++; X++;
            }
        }
        private void manualButton_Click(object sender, EventArgs e)
        {
            ManualForm manual = new ManualForm();
            manual.Show();
        }
        private void GetRightPlace()
        {
            foreach(var figure in figures)
            {
                var figur = figure.GetFigure();
                figur.Location = new Point(figure.GetX(), figure.GetY());
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            TimerStart(interval);
            remember = true;
            timeLabel.Text = "REMEMBER!";
            GetRightPlace();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            time = --time;
            if (time == 0 & remember == true)
            {
                refreshButton_Click(sender, e);
                TimerStart(20);
                remember = false;
                return;
            } else if (remember == false)
            {
                timeLabel.Text = "TIME: " + time.ToString();

                if (time == 0 & RightnessCheck())
                {
                    timeLabel.Text = "Good job!";
                    timer.Stop();
                }
                else if (time == 0 & !RightnessCheck())
                {
                    timer.Stop();
                    MessageBox.Show("You lose!");
                }
            }
        }
        private bool RightnessCheck()
        {
            foreach (var figure in figures)
            {
                if (figure.right_plase != true)
                    return false;
            }

            return true;
        }
        private void TimerStart(int interval)
        {
            time = interval;
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }
    }
}
