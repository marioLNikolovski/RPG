using RPG.Data;
using RPG.Data.Common;
using RPG.Data.Models;
using RPG.Infrastructure;
using RPG.Services;

namespace RPG.Menus
{
    public class InGame : IState
    {
        private readonly KeyCommands _keyCommands;
        private IRPGRepository _repo;
        private char[,] matrix;
        private bool hasStarted = true;
        private int charRow = 1;
        private int charCol = 1;
        private int prevRow = 1;
        private int prevCol = 1;
        public InGame()
        {
            _keyCommands = new KeyCommands();
            _repo = new RPGRepository(new RPGContext());
        }
        public void Execute()
        {
            
            var character = _repo.All<Character>().OrderByDescending(x => x.Id).FirstOrDefault();
            while (character.Health != 0)
            {
                Console.Clear();
                Console.WriteLine($"Health: {character.Health}        Mana: {character.Mana}");
                if(hasStarted)
                {
                    InitialMatrix();
                    hasStarted = false;
                }
                else if(hasStarted == false)
                {
                    PrintMatrix();
                }

                Console.WriteLine("Choose action");
                Console.WriteLine("1)Attack");
                Console.WriteLine("2)Move");
                var response = int.Parse(Console.ReadLine());
                if (response == 1 || response ==2)
                {
                    if (response == 1)
                    {
                        Attack();
                    }
                    if (response == 2)
                    {
                        Move();

                    }
                }
            }    
        }
        public void Move()
        { 
            DirectionKey();
        }
        public void Attack()
        {
            Console.WriteLine("Attacking");
        }
        public void DirectionKey()
        {
            var character = _repo.All<Character>().OrderByDescending(x => x.Id).FirstOrDefault();
            var inputKey = Console.ReadKey(true).Key;
            
            
          
            

            var movements = _keyCommands.Move[inputKey];

            var rowMovement = movements.RowMovement;
            var colMovement = movements.ColMovement;

            prevRow = charRow;
            charRow = charRow + rowMovement;

            prevCol = charCol;
            charCol = charCol + colMovement;

            matrix[charRow, charCol] = character.Symbol.ToCharArray()[0];
            matrix[prevRow, prevCol] = '▒';
         

        }
        public void InitialMatrix()
        {
            int row = 10;
            int col = 10;

             matrix = StartMatrix(row, col);

        }

        public char[,] StartMatrix(int rows, int cols)
        {
            var character = _repo.All<Character>().OrderByDescending(x => x.Id).FirstOrDefault();
            char[,] matrix = new char[rows, cols];
   
            for (int row = 0; row < rows; row++)
            {
                
                for (int col = 0; col < cols; col++)
                {    
                        if (row == 1 && col == 1)
                        {
                            matrix[row, col] = character.Symbol.ToCharArray()[0];
                            Console.Write(matrix[row, col]);
                        }
                        else
                        {
                            matrix[row, col] = '▒';
                            Console.Write(matrix[row, col]);
                        }

                }
                Console.WriteLine();
            }
            return matrix;
        }
        public char[,] PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            return matrix;
        }
    }
}
