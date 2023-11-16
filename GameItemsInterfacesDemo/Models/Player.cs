using System;
namespace GameItemsInterfacesDemo
{
	public class Player
	{
		public string name;
		public string playerCharacterClass;

		public Player()
		{
		}

        public string PromptPlayerToMove()
        {
            Console.WriteLine("Do you want to enter the chamber?");
            return Console.ReadLine();
        }

        public string PromptPlayerToUseItem()
        {
            Console.WriteLine("Do you want to open the chest?");
            return Console.ReadLine();
        }

        public void MoveArea()
        {
            Console.WriteLine("You move along the tunnel passage into a rough hewn chamber of rock.");
            Console.WriteLine("There is a pirate chest in the center of the chamber");
        }

        public void UseItem()
        {
            Console.WriteLine("You carefully open the chest to reveal hundreds of gold coins, a magical necklace of rare likeness, ");
        }
    }
}

