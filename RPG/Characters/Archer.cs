namespace RPG.Characters
{
    public class Archer 
    {
        public double Strenght { get; set; } = 2;
        public double Agility { get; set; } = 4;
        public double Intelligence { get; set; } = 0;
        public double Range { get; set; } = 2;
        public string Symbol { get; set; } = "#";
        public double Health { get; set; }
        public double Mana { get; set; }
        public double Damage { get; set; }

        public Archer()
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
