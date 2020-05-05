
namespace LessonMVC
{
    public interface IView
    {
        event ViewHandler<IView> Changed;
        void SetController(IController cont);
    }
}
