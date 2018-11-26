using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class DogAdapter : IToyDog
    {
        IDog dog;

        public DogAdapter(IDog dog)
        {
            this.dog = dog;
        }

        public void FakeBark()
        {
            dog.Bark();
        }
    }
}
