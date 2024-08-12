using System;//similar to #include
//Helpful hotkey; Ctrl + Shift + b =  compile code.... this will be my preferred way of testing code that I write before having to run it, with potential errors, despite the debugger function.
namespace Revisited_01//Syntax is everything in coding; try not to let it get to you.
{//Ensure all scopes or script bodies are properly syntaxed with the appropriate brackets, as well as the right number of brackets.
    internal class Program//.net core is simply an archive of pre-existing code that we can utilize. This might be applied to the 'using system' notion written at the top of this script.
    {//.net framework is a similar archive, but the .core aspect is Microsoft's attempt to allow different platforms to cross paths, and essentially become compatible with each other. For instance, mac users can now rite in C# on their computers.
        static void Main(string[] args)//all of the code written here is utilizing the .net framework. 
        {//apparently, we can write this same code in the command prompt, utilizing .net commands.
            Console.WriteLine("Hello there. Enter your name please.");//Visual studio and visual studio code are what are referred to as IDE's (Integrated Development Environments), in which code is written. Windows command prompt is technically the same premise.
            var name = Console.ReadLine();//It has been suggested that as we become more experienced developers, the tendency to 'click' around diminishes, and the probability of writing out codes to navigate through different directories increases.
            Console.WriteLine($"Welcome, {name}! Scripting 101.");//Visual studio allows us to write in multiple languages. Why? Because they'd like for more people to use their product.
            //Console.WriteLine("Hello World!");//windows command prompt and windows PowerShell are similar, but think of PowerShell as the newer version of command prompt, with more built in functions, and better compatibility.
        }//when I am seeking to 'cd' (change directory) in command prompt, it's important to understand first that when you open the command prompt, it doesn't necessarily start with just any directory.... it
    }//will likely defer to a very basic directory, from which you will have to correctly map it to the directory you're looking for.
    //To quickly move back one directory in command prompt, simply type in 'cd..' in the console, and you will be move pack one folder, or the parent directory of the one you're currently in. Typing in 'cd.' just keeps you in
    //the same directory. Presumably, using 'cd...' is supposed to move you back two folders, or parent directories, but this has never worked for me. There's currently no known to navigate 'froward' a directory, just change directory
    //your way there.
    //C# is a statically and strongly typed object oriented programming language. Statically means that every variable must have a type at compile time. Strongly refers to how every variable cannot have its type changed, after it's been declared
}
//namespace Revisted_01_1//had errors here
//{
//   internal class Program1
//   {
//       static void Main(string[] args)
//       {
//           Console.WriteLine("Will this program run after the other one has terminated?");
//       }
//   }
//}
