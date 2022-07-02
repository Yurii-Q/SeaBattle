using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class PrintField
    {
        public void printField(Player player)
        {
            Console.WriteLine("Your ships              Opponent ships");
            Console.WriteLine("  a b c d e f g h i j\t  a b c d e f g h i j");
            for (byte i = 0; i < player.getSizeField(); i++)
            {
                Console.Write(i);
                Console.Write(" ");
                for (byte j = 0; j < player.getSizeField(); j++)
                {
                    if (player.getField(i, j) == 0)
                        Console.Write("_ ");
                    else if(player.getField(i, j) == 1)
                        Console.Write("O ");
                    else
                        Console.Write("X ");
                }
                Console.Write("\t");
                Console.Write(i);
                Console.Write(" ");
                for (byte j = 0; j < player.getSizeField(); j++)
                {
                    if (player.getAlienField(i, j) == 0)
                        Console.Write("_ ");
                    else if (player.getAlienField(i, j) == 1)
                        Console.Write("X ");
                    else
                        Console.Write("* ");
                }

                Console.WriteLine("\n");
            }
        }//end printField
    }//end class PrintField
}
