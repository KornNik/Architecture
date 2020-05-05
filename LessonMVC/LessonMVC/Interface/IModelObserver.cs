
namespace LessonMVC
{
    public interface IModelObserver
    {
        void ValueIncremented(IModel model, ModelEventArgs e);
    }
}
