using Mvvm1125;
using System;
using System.Collections.Generic;
using System.Text;

namespace rars
{
    public class MainVM : MvvmNotify
    {
        public string UserTasks { get; set;}
        public string SelectedUserTask { get; set; }

        public MvvmCommand AddTask { get; set; }
        public MvvmCommand DeleteTask { get; set; }
        public MvvmCommand DoneTask { get; set; }

        public MainVM()
        {

        }

    }
}
