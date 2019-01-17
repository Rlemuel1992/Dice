using System;

namespace Dice
{
	class Program
	{
		static void Main()


		{
			int sides;
			Console.WriteLine("Please give me the amount of side you want on your die.");
			int.TryParse(Console.ReadLine(), out sides);

			Random dOne = new Random();
			Random dTwo = new Random();
			int dieOne = DieOne(dOne, sides);
			int dieTwo = DieTwo(dTwo, sides);
			int special = dieOne + dieTwo;

			Console.WriteLine("You rolled a " + dieOne + " and " + dieTwo);
			if (special == 2)
			{
				Console.WriteLine("Snake eyes!");
			}
			else if (special == 12)
			{
				Console.WriteLine("Box car!");
			}
			Continue();
		}
			public static void Continue()
			{
			Console.WriteLine("Do you want to roll again? y/n");
			string cont = Console.ReadLine();
			cont.ToLower();

			{
				if (cont == "y")
				{
					Main();
				}

				else if (cont == "n")
				{
					Console.WriteLine("LATAAAHHHH");
					Environment.Exit(1);
				}

				else
				{
					Console.WriteLine("Try again");
					Continue();
				}
			}
		}
			
		


		public static int DieOne (Random first, int sides)
		{
			int outputOne = first.Next(1, sides++);
			return outputOne;
		}

		public static int DieTwo(Random second, int sides)
		{
			int outputTwo = second.Next(1, sides++);
			return outputTwo;
		}
	}
}
