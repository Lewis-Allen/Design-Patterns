using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Caretaker
    {
        private List<Memento> mementosList = new List<Memento>();

        public void AddToMementoList(Memento memento)
        {
            mementosList.Add(memento);
        }

        public Memento GetMementoAtIndex(int index)
        {
            Memento mementoToReturn = mementosList[index];
            mementosList.Remove(mementosList.Last());
            return mementoToReturn;
        }
    }
}
