using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Observer
{
    class ObserverBinary: BaseObserverView
    {
        private Subject subject;
        private TextBox textBox;

        public ObserverBinary(Subject subject, TextBox textBox)
        {
            this.subject = subject;
            this.textBox = textBox;
        }

        public override void Update()
        {
            // Converts an int value into binary then inserts into text box
            textBox.Text = Convert.ToString(subject.GetValue(), 2);
        }
    }
}
