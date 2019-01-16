using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class OffSwitchCommand : ICommand
    {
        private ISwitchable switchable;

        public OffSwitchCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Execute()
        {
            switchable.PowerOff();
        }
    }
}
