using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// Equivalent to the Receiver Interface
    /// </summary>
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
