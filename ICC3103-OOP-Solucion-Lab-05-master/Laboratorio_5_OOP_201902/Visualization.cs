﻿using Laboratorio_5_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {
        
        public static void ShowHand(Hand hand)
        {
            Console.WriteLine("Hand:\n");
            int counter = 0;
            foreach (Card card in hand.Cards)
            {
                if (card.GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"({counter++}) {card.Name} ({card.GetType()})");
                    Console.ResetColor();
                }

                if (card.GetType().Name == nameof(SpecialCard))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"({counter++}) {card.Name} ({card.GetType()})");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("");
        }   

        public static void ShowDecks(List<Deck> decks)
        {
            Console.WriteLine("Select one deck:\n");
            for (int i = 0; i < decks.Count; i++)
            {
                Console.WriteLine($"({i}) Deck {i+1}");
            }
            Console.WriteLine("");
        }   

        public static void ShowCaptains(List<SpecialCard> captains)
        {
            Console.WriteLine("Select one captain:\n");
            for (int i = 0; i < captains.Count; i++)
            {
                Console.WriteLine($"({i}) {captains[i].Name}: {captains[i].Effect}");
            }
            Console.WriteLine("");
        }

        public static int GetUserInput(int maxInput, bool stopper=false)
        {
            string userInput = Console.ReadLine();
            int inputNumber;
            while (!int.TryParse(userInput, out inputNumber))
            {
                ConsoleError("Input must be a number, try again\n");
                userInput = Console.ReadLine();
            }
            while ((stopper=false) && (inputNumber < 0) && (inputNumber > maxInput))
            {
                ConsoleError($"The option ({inputNumber}) is not valid, try again\n");
                userInput = Console.ReadLine();
            }
            while ((stopper=true) && (inputNumber < -1) && (inputNumber > maxInput))
            {
                ConsoleError($"The option ({inputNumber}) is not valid, try again\n");
                userInput = Console.ReadLine();
            }
            return inputNumber;
        }

        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + message);
            Console.ResetColor();
        }

        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message + "\n");
            Console.ResetColor();
        }

        public static void ShowListOptions(List<string>options, string message=null)
        {
            if (message != null)
            {
                Console.WriteLine(message + "\n");
            }

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
            Console.WriteLine("");
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

    }
}
