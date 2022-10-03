using RPG.Characters;
using RPG.Data;
using RPG.Data.Common;
using RPG.Data.Models;
using RPG.Services;

namespace RPG.Menus
{
    public class CharacterSelectMenu : IState
    {
        private IRPGRepository _repo;

        public CharacterSelectMenu()
        {
            _repo = new RPGRepository(new RPGContext());
        }
        public void Execute()
        {
            while (true)
            {



                Console.Clear();
                Console.WriteLine("Choose character type: ");
                Console.WriteLine("Options: ");
                Console.WriteLine("1) Warrior");
                Console.WriteLine("2) Archer");
                Console.WriteLine("3) Mage");
                Console.WriteLine("Your Pick:");

                var charNumberSelection = int.Parse(Console.ReadLine());



                if (charNumberSelection > 0 && charNumberSelection < 4)
                {
                    if (charNumberSelection == 1)
                    {
                        Warrior warrior = new Warrior();

                        Buff(warrior);
                        return;
                    }
                    else if (charNumberSelection == 2)
                    {
                        Archer archer = new Archer();

                        Buff(archer);
                        return;
                    }
                    else if (charNumberSelection == 3)
                    {
                        Mage mage = new Mage();

                        Buff(mage);
                        return;
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        public void Buff(Object character)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buff up your stats before starting?                    (Limit: 3 points total)");
                Console.WriteLine("Response (Y/N): ");
                var response = Console.ReadLine().ToLower();

                double points = 3;
                double addedPoints = 0;

                if (response == "y")
                {
                    var type = character.GetType();

                    if (type == typeof(Warrior))
                    {
                        var selectedCharacter = (Warrior)character;
                        selectedCharacter.Setup();

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine("Add to Strenght: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Strenght += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };

                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine($"Add to Agility: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Agility += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();

                                return;
                            }
                        }

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine($"Add to Intelligance: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Intelligence += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }

                    }
                    else if (type == typeof(Mage))
                    {
                        var selectedCharacter = (Mage)character;
                        selectedCharacter.Setup();

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine("Add to Strenght: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {

                            selectedCharacter.Strenght += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine($"Add to Agility: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {

                            selectedCharacter.Agility += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine($"Add to Intelligance: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Intelligence += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }
                    }
                    else if (type == typeof(Archer))
                    {
                        var selectedCharacter = (Archer)character;
                        selectedCharacter.Setup();

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine("Add to Strenght: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Strenght += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine($"Add to Agility: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Agility += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }

                        Console.WriteLine($"Remaining points: {points}");
                        Console.WriteLine($"Add to Intelligance: ");

                        addedPoints = double.Parse(Console.ReadLine());

                        if (addedPoints > 0 && addedPoints <= 3)
                        {
                            selectedCharacter.Intelligence += addedPoints;
                            points -= addedPoints;

                            if (points == 0)
                            {
                                Character charcater = new Character
                                {
                                    Strenght = selectedCharacter.Strenght,
                                    Agility = selectedCharacter.Agility,
                                    Intelligence = selectedCharacter.Intelligence,
                                    Health = selectedCharacter.Health,
                                    Mana = selectedCharacter.Mana,
                                    Damage = selectedCharacter.Damage,
                                    Range = selectedCharacter.Range,
                                    Symbol = selectedCharacter.Symbol,
                                    CreatedOn = DateTime.Now,
                                    Name = selectedCharacter.GetType().Name

                                };
                                _repo.AddAsync(charcater);
                                _repo.SaveChanges();
                                return;
                            }
                        }
                    }

                }
                if (response == "n")
                {
                    return;
                }
                else
                {
                    continue;
                }

            }
        }

    }
}
