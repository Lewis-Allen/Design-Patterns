namespace PrototypePattern
{
    class Monster : Prototype
    {
        private int health,
                    age,
                    range,
                    attack,
                    defense;

        private double value = 0.49;

        public Monster(int health, int age, int range, int attack, int defense, double value)
        {
            this.health = health;
            this.age = age;
            this.range = range;
            this.attack = attack;
            this.defense = defense;
            this.value = value;
        }

        public Prototype Clone()
        {
            Prototype clone = new Monster(health, age, range, attack, defense, value);
            
            return clone;
        }

        public override string ToString()
        {
            return $"Health:{health}, Age:{age}, Range:{range}, Attack:{attack}, Defense:{attack}, Value:{value}.";
        }
    }
}
