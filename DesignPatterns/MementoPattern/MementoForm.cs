using System;
using System.Windows.Forms;

namespace MementoPattern
{
    public partial class MementoForm : Form
    {
        private Originator originator = new Originator();
        private Caretaker caretaker = new Caretaker();
        private int currentStep = -1;

        public MementoForm()
        {
            InitializeComponent();
        }
        

        private void AdderBtn_Click(object sender, EventArgs e)
        {
            SaveState();

            int previousValue = int.Parse(TotalTextBox.Text);
            int deltaValue = int.Parse(DeltaTextBox.Text);
            TotalTextBox.Text = (previousValue + deltaValue).ToString();
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            SaveState();

            int previousValue = int.Parse(TotalTextBox.Text);
            int deltaValue = int.Parse(DeltaTextBox.Text);
            TotalTextBox.Text = (previousValue - deltaValue).ToString();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if(currentStep >= 0)
            {
                RestorePreviousValue();
            }
        }

        private void SaveState()
        {
            originator.SetState(int.Parse(TotalTextBox.Text));
            caretaker.AddToMementoList(originator.SaveStateToMemento());
            currentStep++;
        }      
        private void RestorePreviousValue()
        {
            originator.GetStateFromMemento(caretaker.GetMementoAtIndex(currentStep));
            TotalTextBox.Text = originator.GetState().ToString();
            currentStep--;
        }

        private void DeltaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
