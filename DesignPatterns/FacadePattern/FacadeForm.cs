using System;
using System.Windows.Forms;

namespace FacadePattern
{
    public partial class FacadeForm : Form
    {
        Facade facade;
        public FacadeForm()
        {
            InitializeComponent();
            facade = new Facade(this);
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            facade.DepositAmount(Convert.ToDouble(value.Text));
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            facade.WithdrawAmount(Convert.ToDouble(value.Text));
        }
    }
}
