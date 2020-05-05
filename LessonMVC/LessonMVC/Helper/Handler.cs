
namespace LessonMVC
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
}
