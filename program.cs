using System;
using CSharpTerminal;

class DotnetProgram
{
    private static void Main(string[] myArguments)
    {
        Terminal terminal = new Terminal();

        while(true)
        {
            terminal.getTerminalInput();
            terminal.runTerminalCommand();

            // Arguments: {"Eggs", "Spam"}
            // When you need to return them all:
            string argument = terminal.getArgument(1);

            // Check if the argument is "Spam."
            if(argument == "Spam")
            {
                Console.WriteLine("Spam goes well with Eggs!");
            }
        }
    }
}