namespace RPG.Characters
{
    public class Warrior
    {
        public double Strenght { get; set; } = 3;
        public double Agility { get; set; } = 3;
        public double Intelligence { get; set; } = 0;
        public double Range { get; set; } = 1;
        public string Symbol { get; set; } = "@";
        public double Health { get; set; }
        public double Mana { get; set; }
        public double Damage { get; set; }

        public Warrior()
        {

        }

        public void Setup()
        {
            Health = Strenght * 5;
            Mana = Intelligence * 3;
            Damage = Agility * 2;

        }
    }
}
