using System;

namespace LessonMVC
{
    public class ViewEventArgs : EventArgs
    {
        public string Value;
        public ViewEventArgs(string value) => Value = value;
    }
}
