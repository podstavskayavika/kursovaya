using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsGame.Data_Folder
{
    public class DataOperations
    {
        TasksHolder tasksHolder;
        public DataOperations(TasksHolder tasksHolder)
        {
            this.tasksHolder = tasksHolder;
        }
        private int randValue;
        public void GetPictureAndColor(int level, ref string firstImage, ref Color firstColor,
            ref string secondImage, ref Color secondColor)
        {
            Random rnd = new Random();

            foreach (var data in tasksHolder.categories)
            {
                if (data.CategoryNumber == level)
                {
                    randValue = rnd.Next(((Task)data).ImageColorPairs.Count());

                    firstColor = ((Task)data).ImageColorPairs.ElementAt(randValue).Value;
                    firstImage = ((Task)data).ImageColorPairs.ElementAt(randValue).Key;

                    int rndVal = rnd.Next(((Task)data).ImageColorPairs.Count());

                    while (randValue == rndVal)
                    {
                        rndVal = rnd.Next(((Task)data).ImageColorPairs.Count());
                    }

                    secondColor = ((Task)data).ImageColorPairs.ElementAt(rndVal).Value;
                    secondImage = ((Task)data).ImageColorPairs.ElementAt(rndVal).Key;
                }
            }
        }
        public void GetPictures(int level, ref List<string> images, ref List<Color> colors,
            ref Dictionary<int, int> mainImageCoord)
        {
            foreach (var data in tasksHolder.categories)
            {
                if (data.CategoryNumber == level)
                {
                    images = ((Task)data).ImageColorPairs.Keys.ToList();
                    colors = ((Task)data).ImageColorPairs.Values.ToList();

                    mainImageCoord = ((Task)data).MainImageCoord;
                }
            }
        }
    }
}
