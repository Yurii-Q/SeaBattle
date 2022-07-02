// See https://aka.ms/new-console-template for more information

using System;
using SeaBattle;

Player player = new Player();
Player pc = new Player();
PrintField printMyFields = new PrintField();
InputClass inputClass = new InputClass();   

while(true)
{
    printMyFields.printField(player);
    ConsoleKeyInfo inputKey = Console.ReadKey(true);
    if (inputKey.Key == ConsoleKey.Escape || inputKey.KeyChar == 'z') break;

    inputClass.readKey();

    Console.Clear();
}

