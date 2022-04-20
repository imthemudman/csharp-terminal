# C# Terminal
A no-frills terminal using the C# dotnet console application that you can use [freely (public domain.)](LICENSE.txt)

# How It Works
Let's say you type the following input in the terminal:
```
> helloworld Spam,Eggs
```

`helloworld` is the command, the first word. If you type `hello world`, `hello` will be the command, and `world` will be the first argument. When it's done getting the command and arguments, it'll try to look for a command.

`Spam` and `Eggs` are arguments. You type `Spam,Eggs`, so it'll get split in the process. If you type `Pie,Cookies,Brownies`, the arguments gets remembered like:
```cs
string[] = {"Pie", "Cookies", "Brownies"};
```

Overall, once it's done, the class of the terminal will look like:
```cs
// Not the actual variable names, but whatever...
string command = "helloworld";
string[] arguments = {"Spam", "Eggs"};
```

# How to Run It
## Setting it Up
### Using the Directive
First, you need at least the Terminal file (`terminal.cs`,) and have it in your project. 

Next, you'll need to use the directive which is called `CSharpTerminal` by default.

```cs
// Where you put your directives:
using CSharpTerminal;
```
### Initializing
Next, you'll initialize a Terminal object.

```cs
// When you need to initialize it:
Terminal terminal = new Terminal();
```
### Header
If you want: you can add a little text before the command, called the `header` in this terminal.

```cs
// When you need to initialize it WITH GLITTER!:
Terminal terminal = new Terminal("My cool header:>");
```

So, instead of this:
```
helloworld Spam,Eggs
```

You get this:
```
My cool header:> helloworld Spam,Eggs
```

## Getting Consumer Input
Getting input is noteworthy for the terminal; Let's ask for input.
```cs
// When you need to get input:
terminal.getTerminalInput();
```
## Running Terminal Commands
The terminal file comes with a nifty method, so if you have a few commands you want available, no matter when you can use `runTerminalCommand()`. Make sure you check the terminal file and add your command there.

**Program:**
```cs
// When you need to run commands:
terminal.runTerminalCommand();
```

**Terminal:**
```cs
switch(TerminalCommand.ToLower())
{
    // Put commands here:
    // Make sure it's all lowercase.
    default: break;
}
```

So, if you have a command that makes a mad-libs-like sentence with the arguments, you can try this:
```cs
switch(TerminalCommand.ToLower())
{
    // Put commands here:
    // Make sure it's all lowercase.

    case "madlibs":
        madlibs();
        break;
    default: break;
}
```

## Getting the Command Name and Arguments
### Command Name
```cs
// When you need to return the command name:
string command = terminal.getCommand();
```

So, if you want to make a conditional statement if the command is `dinnertime`:

```cs
// When you need to return the command name:
string command = terminal.getCommand();

// Do I need to sing myself a happy tune?
if(command == "dinnertime")
{
    Console.WriteLine("Dinnertime is coming soon!");
}
```
### All Command Arguments
```cs
// When you need to return them all:
string[] arguments = terminal.getArguments();
```

### Specific Command Argument
```cs
// Arguments: {"Eggs", "Spam"}
// When you need to return just one:
string argument = terminal.getArgument(1);

// Check if the argument is "Spam."
if(argument == "Spam")
{
    Console.WriteLine("Spam goes well with Eggs!");
}
```