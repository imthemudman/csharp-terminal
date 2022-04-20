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
        }
    }
}