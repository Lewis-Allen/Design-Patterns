namespace ObserverPattern.Subjects
{
    public class Subject : BaseSubject
    {
        private int Value;

        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            Value = value;
            Notify();
        }
    }
}
