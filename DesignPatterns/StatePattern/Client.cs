using StatePattern.InternetState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Client
    {
        public static void Main()
        {
            InternetConnection connection = new InternetConnection();
            connection.Download();
            connection.Upload();

            connection.SetState(new InternetDisconnected());
            connection.Download();
            connection.Upload();
        }
    }
}
