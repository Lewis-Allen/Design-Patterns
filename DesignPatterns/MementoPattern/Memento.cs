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
