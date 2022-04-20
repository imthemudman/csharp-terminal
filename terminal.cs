/**
  * For the file to use the terminal, go ahead and put it anywhere in your project. 
  * Just make sure you initialize the terminal in your script.
  *
  * Terminal terminal = new Terminal();
  * If you want to run input, fire this method: terminal.getTerminalInput();
  */
using System;

namespace CSharpTerminal {
    public class Terminal
    {
        private static string TerminalHeader = null, TerminalCommand = null;
        private static string[] TerminalArguments = new string[10];

        public Terminal() => TerminalHeader = "";
        public Terminal(string argHeader) => TerminalHeader = argHeader;

        public void getTerminalInput()
        {
            Console.CursorVisible = false;
            int tempArgument = 0; bool tempInLoop = true, tempSaidCommand = false, tempSaidArgument = false; 
            string[] tempTerminalArguments = new string[2]; tempTerminalArguments[0] = "EMPTY COMMAND"; tempTerminalArguments[1] = "EMPTY ARGUMENT";
            
            Console.Write(TerminalHeader);

            while(tempInLoop)
            {
                Console.CursorVisible = true;
                ConsoleKeyInfo tempKeyInfo = Console.ReadKey(true);
                
                switch(tempKeyInfo.Key)
                {
                    case ConsoleKey.Spacebar: if(tempArgument == 0){tempArgument = 1;} else{tempTerminalArguments[1] += " ";} Console.CursorLeft++; break;
                    case ConsoleKey.Backspace:
                        if(tempArgument == 0)
                        {
                            if(tempTerminalArguments[0].Length >= 1)
                            {
                                tempTerminalArguments[0] = tempTerminalArguments[0].Remove(tempTerminalArguments[0].Length - 1, 1);
                                Console.CursorLeft--; Console.Write(" ".ToString()); Console.CursorLeft--;
                            }
                        }
                        else
                        {
                            switch (tempTerminalArguments[1].Length)
                            {
                                case >= 1:
                                    tempTerminalArguments[1] = tempTerminalArguments[1].Remove(tempTerminalArguments[1].Length - 1, 1);
                                    Console.CursorLeft--; Console.Write(" ".ToString()); Console.CursorLeft--; break;
                                default: if ((tempTerminalArguments[1].Length == 0) || (tempTerminalArguments[1] == null)) { tempArgument = 0; Console.CursorLeft -= 1; } break;
                            }
                        }
                        break;   
                        case ConsoleKey.Enter: tempArgument = 0; tempInLoop = false; Console.Write("\n"); break;
                        default: 
                            if(tempArgument == 0 && !tempSaidCommand){tempTerminalArguments[0] = null; tempSaidCommand = true;}
                            if(tempArgument == 1 && !tempSaidArgument){tempTerminalArguments[1] = null; tempSaidArgument = true;}
                            tempTerminalArguments[tempArgument] += tempKeyInfo.KeyChar.ToString(); 
                            Console.Write(tempKeyInfo.KeyChar.ToString()); break;
                }
            }      

            Console.CursorVisible = false; TerminalCommand = tempTerminalArguments[0];
            if(tempTerminalArguments[0] == "EMPTY COMMAND"){TerminalCommand = null;}
            switch (tempTerminalArguments[1])
            {
                case "EMPTY ARGUMENT": tempTerminalArguments[1] = null; break;
                default: if (tempTerminalArguments[1] != null) { TerminalArguments = tempTerminalArguments[1].Split(','); } break;
            }       
        }

        public void runTerminalCommand()
        {
            if(TerminalCommand != null)
            {
                switch(TerminalCommand.ToLower())
                {
                    // Put commands here:
                    // Make sure it's all lowercase.
                    default: break;
                }
            }
        }

        public string getCommand() => TerminalCommand;
        public string[] getArguments() => TerminalArguments;
        public string getArgument(int argArraySlot) => TerminalArguments[argArraySlot];
    }
}