using RPG.Menus;

namespace RPG
{
    public class Engine
    {
        public void RunMainMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Execute();
        }

        public void RunCharacterSelectMenu()
        {
            CharacterSelectMenu characterSelectMenu = new CharacterSelectMenu();
            characterSelectMenu.Execute();
        }

        public void RunInGame()
        {
            InGame inGame = new InGame();
            inGame.Execute();
        }
    }
}
