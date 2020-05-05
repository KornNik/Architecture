using System;

namespace LessonMVC
{
    public class ModelEventArgs : EventArgs
    {
        public string Value;
        public ModelEventArgs(string value) => Value = value;
    }
}
