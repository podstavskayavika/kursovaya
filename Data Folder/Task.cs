using System;
using System.Collections.Generic;
using System.Drawing;

namespace KidsGame.Data_Folder
{
    [Serializable]
    public class Task : Category
    {
        public Dictionary<string, Color> ImageColorPairs = new Dictionary<string, Color>();
        public Dictionary<int, int> MainImageCoord = new Dictionary<int, int>();
        public string ImagePath;
        public Task(int CategoryNumber, string CategoryName,
            Dictionary<string, Color> ImageColorPairs) 
            : base (CategoryNumber, CategoryName)
        {
            this.ImageColorPairs = ImageColorPairs;
        }

        public Task() { }

        public Task(int CategoryNumber, string CategoryName, Dictionary<int, int> MainImageCoord,
            Dictionary<string, Color> ImageColorPairs)
            : base (CategoryNumber, CategoryName)
        {
            this.ImageColorPairs = ImageColorPairs;
            this.MainImageCoord = MainImageCoord;
        }
    }
}
