using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.InternetState
{
    class InternetConnected : IInternetState
    {
        private readonly string stateDescription = "The internet is connected.";

        public InternetConnected()
        {
            Console.WriteLine(stateDescription);
        }

        public void Download()
        {
            Console.WriteLine("You are able to download off the internet.");
        }

        public void Upload()
        {
            Console.WriteLine("You are able to upload off the internet.");
        }
    }
}
