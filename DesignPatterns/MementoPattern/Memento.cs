using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento
    {
        private readonly int state;

        public Memento(int state)
        {
            this.state = state;
        }

        public int GetState()
        {
            return state;
        }
    }
}
