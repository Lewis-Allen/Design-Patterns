using ObserverPattern.Observers;
using ObserverPattern.Subjects;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class ObserverForm : Form
    {
        private Subject subject;

        ObserverDecimal decObserver;
        ObserverBinary binObserver;
        ObserverHex hexObserver;

        public ObserverForm()
        {
            InitializeComponent();

            subject = new Subject();

            decObserver = new ObserverDecimal(subject, textBox1);
            binObserver = new ObserverBinary(subject, textBox2);
            hexObserver = new ObserverHex(subject, textBox3);

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

        private void decimalObserverDetach_Click(object sender, System.EventArgs e)
        {
            DetachObserver(decimalAttachDetachBtn, decObserver);
        }

        private void binaryObserverDetach_Click(object sender, System.EventArgs e)
        {
            DetachObserver(binaryAttachDetachBtn, binObserver);

        }

        private void hexObserverDetach_Click(object sender, System.EventArgs e)
        {
            DetachObserver(hexAttachDetachBtn, hexObserver);
        }

        private void DetachObserver(Button button, BaseObserverView observer)
        {
            if (button.Text.Equals("Detach"))
            {
                subject.Detach(observer);
                button.Text = "Attach";
            }
            else
            {
                subject.Attach(observer);
                button.Text = "Detach";
            }
        }
    }
}
