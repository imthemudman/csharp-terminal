using System;
using CSharpTerminal;

class DotnetProgram
{
    private static void Main(string[] args)
    {
        Terminal terminal = new Terminal();

        while(true)
        {
            terminal.getTerminalInput();
            terminal.runTerminalCommand();
        }
    }
}
