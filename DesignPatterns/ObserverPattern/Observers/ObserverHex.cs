using ObserverPattern.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern.Observers
{
    class ObserverHex: BaseObserverView
    {
        private Subject subject;
        private TextBox textBox;

        public ObserverHex(Subject subject, TextBox textBox)
        {
            this.subject = subject;
            this.textBox = textBox;
        }

        public override void Update()
        {
            // https://stackoverflow.com/questions/1139957/c-sharp-convert-integer-to-hex-and-back-again
            // Converts an int value into hex then inserts into text box
            textBox.Text = subject.GetValue().ToString("X");
        }
    }
}
