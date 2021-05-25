using KidsGame.Data_Folder;
using KidsGame.User_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsGame
{
    public partial class GameScreen : Form
    {
        DataOperations dataOperations;
        public GameScreen(DataOperations dataOperations)
        {
            InitializeComponent();
            SetGraphics(firstCanvas.Width, firstCanvas.Height);

            this.dataOperations = dataOperations;

            SetPictures(firstImage, secondImage);
        }
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) 
                    size = 2;
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                    index = 0;
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountOfPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }

        private bool isMousePressed = false, isButtonPressed = false, firstOrSecond = false;
        private const int level = 1;
        private string imageN1, imageN2;
        private Color firstColor, secondColor;
        private ArrayPoints firstArrayPoints = new ArrayPoints(2); // конструктор принимает толщину пера
        private ArrayPoints secondArrayPoints = new ArrayPoints(2);

        Bitmap firstMap = new Bitmap(100, 100); // конструктор принимает размер первого холста
        Bitmap secondMap = new Bitmap(100, 100); //                             второго

        Graphics firstGraphics;
        Graphics secondGraphics;

        Pen pen = new Pen(Color.Black, 3f); // конструктор принимает цвет пера и его толщину

        private void SetGraphics(int width, int height)
        {
            firstMap = new Bitmap(width, height); // задаем bitmap`у размеры холста
            secondMap = new Bitmap(width, height); // задаем bitmap`у размеры холста
            firstGraphics = Graphics.FromImage(firstMap);
            secondGraphics = Graphics.FromImage(secondMap);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round; // сглаживание линии в начале
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; // сглаживание линии в конце
        }
        private void ClearCanvas(PictureBox canvas, Bitmap map, Graphics graphics)
        {
            graphics.Clear(canvas.BackColor);
            canvas.Image = map;
        }
        private void SetPictures(PictureBox firstTaskCanvas, PictureBox secondTaskCanvas)
        {
            dataOperations.GetPictureAndColor(level, ref imageN1, ref firstColor,
                ref imageN2, ref secondColor);

            firstTaskCanvas.BackgroundImage = new Bitmap(imageN1);
            secondTaskCanvas.BackgroundImage = new Bitmap(imageN2);
        }
        private void Drawing(ArrayPoints points, Graphics graphics, PictureBox canvas,
            Bitmap map, MouseEventArgs e)
        {
            if (!isMousePressed)
                return;
            points.SetPoint(e.X, e.Y);
            if (points.GetCountOfPoints() >= 2)
            {
                graphics.DrawLines(pen, points.GetPoints());
                canvas.Image = map;
                points.SetPoint(e.X, e.Y);
            }
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            firstCheckBox.Visible = secondCheckBox.Visible = false;
        }
        private void firstCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
                firstOrSecond = true;
                isMousePressed = true;
            //} else if (e.Button == MouseButtons.Right)
            //{
            //    Fill(e.X, e.Y, pen.Color);
            //}
        } // нажатие на холст
        private void firstCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            firstArrayPoints.ResetPoints();
        } // отжатие холста :)
        private void firstCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Drawing(firstArrayPoints, firstGraphics, firstCanvas, firstMap, e);
        } // непосредственно рисование на первом холсте
        private void clearCanvasButton_Click(object sender, EventArgs e)
        {
            if (isButtonPressed)
            {
                if (firstCheckBox.Checked & secondCheckBox.Checked)
                {
                    ClearCanvas(firstCanvas, firstMap, firstGraphics);
                    ClearCanvas(secondCanvas, secondMap, secondGraphics);
                }
                else if (secondCheckBox.Checked)
                    ClearCanvas(secondCanvas, secondMap, secondGraphics);
                else if (firstCheckBox.Checked)
                    ClearCanvas(firstCanvas, firstMap, firstGraphics);
                else
                    MessageBox.Show("Choose at list one canvas");

                firstCheckBox.Visible = secondCheckBox.Visible = isButtonPressed =
                    firstCheckBox.Checked = secondCheckBox.Checked = false;
            }
            else
            {
                firstCheckBox.Visible = secondCheckBox.Visible = isButtonPressed = true;
            }
        } // кнопка для очистки холста
        private void secondCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            firstOrSecond = false;
            isMousePressed = true;
        }
        private void secondCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            secondArrayPoints.ResetPoints();
        } // непосредственно рисование на втором холсте
        private void randomButton_Click(object sender, EventArgs e)
        {
            SetPictures(firstImage, secondImage);
            firstCheckBox.Checked = secondCheckBox.Checked = isButtonPressed = true;
            clearCanvasButton_Click(sender, e);
            
        }
        private void changeColor_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }
        private void paletteButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                ((Button)sender).BackColor = colorDialog.Color;
            }
        }
        /* private void Fill(int x, int y, Color color) {
            if (firstOrSecond)
            {
                firstGraphics.DrawLine(new Pen(color), x, y, x, y + 0.5f);

                if (firstMap.GetPixel(x + 1, y).ToArgb() != color.ToArgb())
                    Fill(x + 1, y, color);
                if (firstMap.GetPixel(x - 1, y).ToArgb() != color.ToArgb())
                    Fill(x - 1, y, color);
                if (firstMap.GetPixel(x, y + 1).ToArgb() != color.ToArgb())
                    Fill(x, y + 1, color);
                if (firstMap.GetPixel(x, y - 1).ToArgb() != color.ToArgb())
                    Fill(x, y - 1, color);
            }
            else
            {
                secondGraphics.DrawLine(new Pen(color), x, y, x, y + 0.5f);

                if (secondMap.GetPixel(x + 1, y).ToArgb() != color.ToArgb())
                    Fill(x + 1, y, color);
                if (secondMap.GetPixel(x - 1, y).ToArgb() != color.ToArgb())
                    Fill(x - 1, y, color);
                if (secondMap.GetPixel(x, y + 1).ToArgb() != color.ToArgb())
                    Fill(x, y + 1, color);
                if (secondMap.GetPixel(x, y - 1).ToArgb() != color.ToArgb())
                    Fill(x, y - 1, color);
            }
        } */
        private void secondCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Drawing(secondArrayPoints, secondGraphics, secondCanvas, secondMap, e);
        }
        private void SaveFile(PictureBox canvas)
        {
            savePictureDialog.Filter = "JPG(*.JPG)|*.jpg";
            if (savePictureDialog.ShowDialog() == DialogResult.OK)
            {
                if (canvas.Image != null)
                {
                    canvas.Image.Save(savePictureDialog.FileName);
                }
            }
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (isButtonPressed)
            {
                if (firstCheckBox.Checked & secondCheckBox.Checked)
                {
                    SaveFile(firstCanvas);
                    SaveFile(secondCanvas);
                }
                else if (secondCheckBox.Checked)
                    SaveFile(secondCanvas);
                else if (firstCheckBox.Checked && secondCheckBox.Checked)
                    SaveFile(firstCanvas);
                else
                    MessageBox.Show("Choose at list one canvas");

                firstCheckBox.Visible = secondCheckBox.Visible = isButtonPressed =
                    firstCheckBox.Checked = secondCheckBox.Checked = false;
            }
            else
            {
                firstCheckBox.Visible = secondCheckBox.Visible = isButtonPressed = true;
            }
        }
    }
}
