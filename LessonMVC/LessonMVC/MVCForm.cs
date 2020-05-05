using System;
using System.Windows.Forms;

namespace LessonMVC
{
    public partial class MVCForm : Form, IView, IModelObserver
    {
        IController controller;
        public event ViewHandler<IView> Changed;

        public MVCForm()
        {
            InitializeComponent();
        }

        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        public void ValueIncremented(IModel model, ModelEventArgs modelEvent)
        {
            ListBox.Items.Add(modelEvent.Value);
        }

        private void ButtonValue_Click(object sender, EventArgs e)
        {
            Changed.Invoke(this, new ViewEventArgs(TextBox.Text));
        }

    }
}
