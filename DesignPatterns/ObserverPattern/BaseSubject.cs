using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class BaseSubject
    {
        private List<BaseObserverView> observers = new List<BaseObserverView>();

        public void Attach(BaseObserverView observer)
        {
            observers.Add(observer);
        }

        public void Detach(BaseObserverView observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (BaseObserverView observer in observers)
            {
                observer.Update();
            }
        }

    }
}
