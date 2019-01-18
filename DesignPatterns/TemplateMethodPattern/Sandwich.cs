using System;

namespace TemplateMethodPattern
{
    abstract class Sandwich
    {
        public void Make()
        {
            SliceBread();
            AddSpread();
            AddCheese();
            AddMeat();
            AddSalad();
        }

        // Methods with common functionality can be defined.
        public void SliceBread()
        {
            Console.WriteLine("You cut some bread into slices.");
        }

        // Methods without common functionality will be made available for overriding in concrete classes.
        public virtual void AddSpread() { }

        public virtual void AddCheese() { }

        public virtual void AddMeat() { }

        public virtual void AddSalad() { }

        // Methods which must be implemented are defined as abstract.
        public abstract void Eat();
    }
}
