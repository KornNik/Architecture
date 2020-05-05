
namespace LessonMVC
{
    public interface IModel
    {
        void Attach(IModelObserver modelObserver);
        void SetValue(string value);
    }
}
