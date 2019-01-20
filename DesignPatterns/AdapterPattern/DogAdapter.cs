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
