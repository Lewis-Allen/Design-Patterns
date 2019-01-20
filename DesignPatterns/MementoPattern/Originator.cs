namespace MementoPattern
{
    public class Originator
    {
        private int state;

        public void SetState(int state)
        {
            this.state = state;
        }

        public int GetState()
        {
            return state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            state = memento.GetState();
        }
    }
}
