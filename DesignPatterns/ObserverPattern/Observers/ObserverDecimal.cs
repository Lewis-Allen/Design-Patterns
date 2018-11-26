using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Observer
{
    class ObserverDecimal : BaseObserverView
    {
        private Subject subject;
        private TextBox textBox;

        public ObserverDecimal(Subject subject, TextBox textBox)
        {
            this.subject = subject;
            this.textBox = textBox;
        }

        public override void Update()
        {
            textBox.Text = subject.GetValue().ToString();
        }
    }
}
