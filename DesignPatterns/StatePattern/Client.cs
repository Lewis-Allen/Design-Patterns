using StatePattern.InternetState;

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
