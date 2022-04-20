using System;
using CSharpTerminal;

class DotnetProgram
{
    private static void Main(string[] arguments)
    {
        Terminal terminal = new Terminal();

        while(true)
        {
            terminal.getTerminalInput();
        }
    }
}