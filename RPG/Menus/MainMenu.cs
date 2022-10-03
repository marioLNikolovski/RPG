using RPG.Services;

namespace RPG.Menus
{
    public class MainMenu : IState
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Press any key to play.");
            Console.ReadKey();
        }
    }
}
