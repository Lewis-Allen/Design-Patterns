using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class OnSwitchCommand : ICommand
    {
        private ISwitchable switchable;

        public OnSwitchCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Execute()
        {
            switchable.PowerOn();
        }
    }
}
