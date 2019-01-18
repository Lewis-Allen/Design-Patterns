using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.InternetState
{
    class InternetDisconnected : IInternetState
    {
        private readonly string stateDescription = "The internet is disconnected.";

        public InternetDisconnected()
        {
            Console.WriteLine(stateDescription);
        }
        public void Download()
        {
            Console.WriteLine("You can't download anything.");
        }

        public void Upload()
        {
            Console.WriteLine("You can't upload anything.");
        }
    }
}
