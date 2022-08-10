// See https://aka.ms/new-console-template for more information

using System;
using SeaBattle;

Player player = new Player();
Player pc = new Player();

InputClassPlayer inputClassPlayer = new InputClassPlayer();   
InputClassPC inputClassPC = new InputClassPC();   

Handler handler = new Handler();

while(true)
{
    PrintField.printField(player);    

    if(inputClassPlayer.readKeyPlayer(player, handler))break;   
    inputClassPC.readKeyPC(pc, handler);

    if (handler.handler(player, pc) != 0)
    {
        PrintField.printField(player);

        if (handler.handler(player, pc) == 1)            
            Console.WriteLine("You Win!");
        else
            Console.WriteLine("You Lose!");
        break;
    }
}

