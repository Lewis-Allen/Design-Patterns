using ObserverPattern;
using System;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class DesignPatternsForm : Form
    {
        public DesignPatternsForm()
        {
            InitializeComponent();
        }

        private void AdapterPatternBtn_Click(object sender, EventArgs e)
        {
            AdapterPattern.Client.Main();
        }

        private void ObserverPatternBtn_Click(object sender, EventArgs e)
        {
            Form observerForm = new ObserverForm();
            observerForm.Show();
        }

        private void DecoratorPatternBtn_Click(object sender, EventArgs e)
        {
            DecoratorPattern.Client.Main();
        }
    }
}
