using FacadePattern;
using MediatorPattern;
using MementoPattern;
using ObserverPattern;
using ProxyPattern;
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

        private void FacadePatternBtn_Click(object sender, EventArgs e)
        {
            Form facadeForm = new FacadeForm();
            facadeForm.Show();
        }

        private void ProxyPatternBtn_Click(object sender, EventArgs e)
        {
            Form proxyPattern = new ProxyForm();
            proxyPattern.Show();
        }

        private void CompositePatternBtn_Click(object sender, EventArgs e)
        {
            CompositePattern.Client.Main();
        }

        private void SingletonPatternBtn_Click(object sender, EventArgs e)
        {
            SingletonPattern.Client.Main();
        }

        private void IteratorPatternBtn_Click(object sender, EventArgs e)
        {
            IteratorPattern.Client.Main();
        }

        private void FlyweightPatternBtn_Click(object sender, EventArgs e)
        {
            FlyweightPattern.Client.Main();
        }

        private void BridgePatternBtn_Click(object sender, EventArgs e)
        {
            BridgePattern.Client.Main();
        }

        private void StrategyPatternBtn_Click(object sender, EventArgs e)
        {
            StrategyPattern.Client.Main();
        }

        private void MementoPatternBtn_Click(object sender, EventArgs e)
        {
            Form mementoPattern = new MementoForm();
            mementoPattern.Show();
        }

        private void CommandPatternBtn_Click(object sender, EventArgs e)
        {
            CommandPattern.Client.Main();
        }

        private void AbstractFactoryPattern_Click(object sender, EventArgs e)
        {
            AbstractFactoryPattern.Charlie.Main();
        }


        private void MediatorPattern_Click(object sender, EventArgs e)
        {
            Form mediatorPattern = new MediatorForm();
            mediatorPattern.Show();
        }

        private void StatePattern_Click(object sender, EventArgs e)
        {
            StatePattern.Client.Main();
        }

        private void BuilderPattern_Click(object sender, EventArgs e)
        {
            BuilderPattern.Client.Main();
        }

        private void FactoryMethodPattern_Click(object sender, EventArgs e)
        {
            FactoryMethodPattern.Client.Main();
        }

        private void PrototypePattern_Click(object sender, EventArgs e)
        {
            PrototypePattern.Client.Main();
        }

        private void TemplateMethodPattern_Click(object sender, EventArgs e)
        {
            TemplateMethodPattern.Client.Main();
        }

        private void ChainOfResponsibilityPattern_Click(object sender, EventArgs e)
        {
            ChainOfResponsibilityPattern.Client.Main();
        }

        private void VisitorPattern_Click(object sender, EventArgs e)
        {
            VisitorPattern.Client.Main();
        }
    }
}
