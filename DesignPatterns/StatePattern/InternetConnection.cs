using StatePattern.InternetState;

namespace StatePattern
{
    public class InternetConnection
    {
        IInternetState currentState;
        public void SetState(IInternetState state) => currentState = state;

        public InternetConnection()
        {
            SetState(new InternetConnected());
        }

        public void Download()
        {
            currentState.Download();
        }

        public void Upload()
        {
            currentState.Upload();
        }
    }
}
