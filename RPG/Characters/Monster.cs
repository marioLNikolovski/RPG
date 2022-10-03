namespace RPG.Characters
{
    public class Monster
    {


        public double Strenght { get; set; } = (new Random()).Next(1,4);
        public double Agility { get; set; } = (new Random()).Next(1, 4);
        public double Intelligence { get; set; } = (new Random()).Next(1, 4);
        public double Range { get; set; } = 1;
        public string Symbol { get; set; } = "◙";
        public double Health { get; set; }
        public double Mana { get; set; }
        public double Damage { get; set; }

        public Monster()
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
