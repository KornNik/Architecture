using System.Collections.Generic;

namespace LessonMVC
{
    public class IncrementModel : IModel
    {
        public event ModelHandler<IncrementModel> Changed;
        private List<string> _list;

        public IncrementModel() => _list = new List<string>();
        public void SetValue(string value)
        {
            _list.Add(value);
            Changed.Invoke(this, new ModelEventArgs(value));
        }
        public void Attach(IModelObserver modelObserver) => Changed += new ModelHandler<IncrementModel>(modelObserver.ValueIncremented);

    }
}
