using Laboratorio_5_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {
        
        public static void ShowHand(Hand hand)
        {
            int counter = 0;
            foreach (Card card in hand.Cards)
            {
                if (card.GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"({counter++}): {card.Name}");
                    Console.ResetColor();
                }

                if (card.GetType().Name == nameof(SpecialCard))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"({counter++}): {card.Name}");
                    Console.ResetColor();
                }
            }
        }

        public static void ShowDecks(List<Deck> decks)
        {

        }

        public static void GetUserInput(int maxInput, bool stopper=false)
        {

        }

        public static void ConsoleError(string message)
        {

        }

        public static void ShowProgramMessage(string message)
        {

        }

        public static void ShowListOptions (List<string>options, string message=null)
        {

        }

        public static void ClearConsole()
        {

        }

    }
}
