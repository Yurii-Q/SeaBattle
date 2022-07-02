using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal sealed class Player
    {
        Random random = new Random();

        private const int sizeField = 10;

        private int numberShips = 10;//Maximal number of ship

        //0("_") - empty, 1("O") - ship, 2("X") - shot ship
        private byte[,] myField = new byte[sizeField, sizeField];
        //0("_") - empty, 1("X") - shot ship, 2("*") - miss
        private byte[,] alienField = new byte[sizeField, sizeField];

        public Player()
        {
            zeroingField();
            fillMyField();
        }

        public int getSizeField()
        {
            return sizeField;
        }

        public int getField(int i, int j)
        {
            return myField[i, j];
        }

        public int getAlienField(int i, int j)
        {
            return alienField[i, j];
        }

        private void zeroingField()
        {
            for (byte i = 0; i < sizeField; i++)
            {
                for (byte j = 0; j < sizeField; j++)
                {
                    myField[i, j] = 0;
                    alienField[i, j] = 0;
                }
            }
        }//end zeroingField
       
        private void fillMyField()
        {
            while (numberShips != 0)
            {
                int i = random.Next(sizeField);
                int j = random.Next(sizeField);

                if (myField[i, j] == 0)
                {
                    if (i > 0 && i < sizeField - 1 && j > 0 && j < sizeField - 1)
                    {
                        if (myField[i + 1, j] == 0 && myField[i - 1, j] == 0 &&
                            myField[i, j + 1] == 0 && myField[i, j - 1] == 0 && myField[i + 1, j + 1] == 0 &&
                            myField[i - 1, j - 1] == 0 && myField[i + 1, j - 1] == 0 && myField[i - 1, j + 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (i == 0 && j == 0)
                    {
                        if (myField[i + 1, j] == 0 && myField[i, j + 1] == 0 && myField[i + 1, j + 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (i == sizeField - 1 && j == sizeField - 1)
                    {
                        if (myField[i - 1, j] == 0 && myField[i, j - 1] == 0 && myField[i - 1, j - 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (i == sizeField - 1 && j == 0)
                    {
                        if (myField[i - 1, j] == 0 && myField[i, j + 1] == 0 && myField[i - 1, j + 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (i == 0 && j == sizeField - 1)
                    {
                        if (myField[i + 1, j] == 0 && myField[i, j - 1] == 0 && myField[i + 1, j - 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (i == 0)
                    {
                        if (myField[i , j + 1] == 0 && myField[i , j - 1] == 0 && myField[i + 1, j] == 0 && 
                            myField[i + 1, j + 1] == 0 && myField[i + 1, j - 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (i == sizeField - 1)
                    {
                        if (myField[i - 1, j] == 0 && myField[i - 1, j + 1] == 0 && myField[i, j - 1] == 0 &&
                            myField[i, j + 1] == 0 && myField[i - 1, j - 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (j == 0)
                    {
                        if (myField[i + 1, j] == 0 && myField[i - 1, j] == 0 && myField[i, j + 1] == 0 &&
                            myField[i - 1, j + 1] == 0 && myField[i + 1, j + 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                    else if (j == sizeField-1)
                    {
                        if (myField[i - 1, j] == 0 && myField[i + 1, j] == 0 && myField[i, j - 1] == 0 &&
                            myField[i - 1, j - 1] == 0 && myField[i + 1, j - 1] == 0)
                        {
                            myField[i, j] = 1;
                            numberShips--;
                            continue;
                        }
                    }
                }               
            }
        }//end fillMyField
    }//end class Player
}//end namespace SeaBattle
