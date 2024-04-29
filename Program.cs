namespace B02_TextRPG
{
    public class GameManager
    {
        public GameManager()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MainMenu.mainMenu();
            Character.ShowInfo();
        }
    }
}
