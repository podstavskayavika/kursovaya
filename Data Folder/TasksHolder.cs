using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KidsGame.Data_Folder
{
    [Serializable]
    [XmlInclude(typeof(Task))]
    public class TasksHolder
    {
        public List<Category> categories = new List<Category>();
        public TasksHolder() { }
    }
}
