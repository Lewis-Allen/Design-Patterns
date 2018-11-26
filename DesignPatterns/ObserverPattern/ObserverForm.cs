using DesignPatterns.Observer;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class ObserverForm : Form
    {
        private Subject subject;

        public ObserverForm()
        {
            InitializeComponent();

            subject = new Subject();

            ObserverDecimal decObserver = new ObserverDecimal(subject, textBox1);
            ObserverBinary binObserver = new ObserverBinary(subject, textBox2);
            ObserverHex hexObserver = new ObserverHex(subject, textBox3);

            subject.Attach(decObserver);
            subject.Attach(binObserver);
            subject.Attach(hexObserver);

            subject.SetValue(42);
        }

        private void Increment_Click(object sender, System.EventArgs e)
        {
            subject.SetValue(subject.GetValue() + 1);
        }

        private void Decrement_Click(object sender, System.EventArgs e)
        {
            subject.SetValue(subject.GetValue() - 1);
        }
    }
}
