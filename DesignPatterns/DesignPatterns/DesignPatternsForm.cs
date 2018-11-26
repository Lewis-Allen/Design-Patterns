using ObserverPattern;
using System;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
