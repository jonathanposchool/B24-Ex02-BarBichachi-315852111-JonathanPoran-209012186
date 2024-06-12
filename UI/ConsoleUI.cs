using System;
using GenericCardGame;
namespace UI
{
    public class ConsoleUI : GameUI
    {
        public override void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public override string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
