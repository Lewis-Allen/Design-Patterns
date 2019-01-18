using System.Windows.Forms;

namespace MediatorPattern
{
    class ConcreteMediator : Mediator
    {
        private Label label1;
        private Label label2;

        public ConcreteMediator(Label label1, Label label2)
        {
            this.label1 = label1;
            this.label2 = label2;
        }
        public void Increment()
        {
            ChangeLabelValues(1);
        }

        public void Decrement()
        {
            ChangeLabelValues(-1);
        }

        private void ChangeLabelValues(int change)
        {
            label1.Text = (int.Parse(label1.Text) + change).ToString();
            label2.Text = (int.Parse(label2.Text) + change).ToString();
        }
    }
}
