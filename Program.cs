using KidsGame.Data_Folder;
using KidsGame.User_Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = KidsGame.Data_Folder.Task;

namespace KidsGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            TasksHolder holder = new TasksHolder();

            Dictionary<string, Color> Pairs = new Dictionary<string, Color> 
            {
                { "../../img/1/1_1.png", Color.Blue },
                { "../../img/1/1_2.png", Color.Green },
                { "../../img/1/1_3.png", Color.Pink }
            };

            holder.categories.Add(new Task(1, "Paint", Pairs));

            Dictionary<string, Color> Pairs2 = new Dictionary<string, Color>
            {
                { "../../img/2/2_1.png", Color.Green },
                { "../../img/2/2_2.png", Color.Red },
                { "../../img/2/2_3.png", Color.Yellow }
            };

            Dictionary<int, int> Pairs3 = new Dictionary<int, int>
            {
                { 355, 12 },
                { 356, 112 },
                { 357, 212 }
            };

            holder.categories.Add(new Task(2, "Move", Pairs3, Pairs2));

            DataOperations dataOp = new DataOperations(holder);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameMenu(dataOp));
            //Application.Run(new GameScreen(dataOp));
        }
    }
}
