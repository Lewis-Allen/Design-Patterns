using System;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class MediatorForm : Form
    {
        Mediator mediator;
        public MediatorForm()
        {
            InitializeComponent();
            mediator = new ConcreteMediator(label1, label2);
        }

        private void Increment_Click(object sender, EventArgs e)
        {
            mediator.Increment();
        }

        private void Decrement_Click(object sender, EventArgs e)
        {
            mediator.Decrement();
        }
    }
}
