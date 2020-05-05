
namespace LessonMVC
{
    public class IncrementController : IController
    {
        private IView view;
        private IModel model;
        public IncrementController(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            this.view.SetController(this);
            this.model.Attach((IModelObserver)view);
            this.view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }
        public void ViewChanged(IView view, ViewEventArgs viewEvent) =>
                                                   model.SetValue(viewEvent.Value);
        public void AddValue(string value) => model.SetValue(value);
    }

}
