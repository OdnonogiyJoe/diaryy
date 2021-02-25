using System;
using System.Collections.Generic;
using System.Text;

namespace rars
{
    public class UserTaskDone: IUserTask
    {
        public DateTime DateDone { get; set; }
        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DateCreate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
