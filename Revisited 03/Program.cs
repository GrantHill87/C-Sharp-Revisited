using System;//Be advised that on the very right portion of the default work screen, there's typically a lesser window titled, 'Solution Explorer'. Sometimes, the visual studio program likes to change it over to 'properties'
//This can be changed back to the solution explorer option simply clicking on its appropriate tab at the very bottom right of the work screen.
namespace C_Sharp_Revisited_01A//Note that when creating new solution files in C #, on visual studio, generally want to select the new console app C # option, and then select the second console app option on the right side.
{//Then, others have suggested that it's not a bad idea to name the project portion of your solution file as something different than the solution file itself.... in this case, I added the word console to the project file portion.
    internal class Program//Now, when I did this manually in Windows, it worked without issue. However, when I sought to open the same solution file, with the now altered project file in it, or better yet; when
    {//when I attempted to test the script, or tried to get it to run, visual studio kept coming back to me, suggesting that it couldn't load the project file, which just had its name changed. It didn't say what the problem was,
        public static void Main(string[] args)//but because I was aware of what had just taken place with that project file, I was able to focus on the cause of the problem. The internet, or Microsoft edge web browser, didn't exactly do a good job
        {//of explaining to me where to locate a file path configuration for visual studio, at least per solution file or project file loaded, so I figured it out myself. So, first thing to do is go over to the right
            Console.WriteLine("C # Revisited 01");//work screen and find your project file in it; right click on it, and select properties. This should bring up a new tab in the main work scene, on the far left, and while that tab is
            //open, go back over to the solution explorer tab, and switch it over to properties. At the top of that work screen on the right, there should be a 'File Name' configuration --  this is where you can update the project file name, so that it will load properly.
            //Variable Declarations
            int Age;//Green squiggly underlining means that a declared variable simply hasn't been called yet (used yet).
            string Name;//C# is a strongly static, object oriented coding language -- means all variables must be assigned a value and a type, and that data is stored within them.
            bool isWorking;//Each of these variables stores data in the form of its type.
            //Variable Initializations
            Age = 42;
            Name = "'82 Ford Escort";//Remember that a string can accept numbers as stored values in its data, but it cannot calculate them.
            isWorking = true;//Literally writes out whatever is put here, when it's called, so string types may be more flexible here.
            //These are elements found in Module 2 exercises of the TrueCoders Software engineering self paced program.
            Console.WriteLine($"The old {Name}, {Age} years of age, is still kickin'? {isWorking}.");//
            //Here, we'll encounter elements of exercises found in the TrueCoders software engineering self paced program, Module 3.
            //public static void Main1(string[] args)//Despite having made a new namespace and new class (program), an error still shows up where the class program has 'more than one entry point defined'.
            //{//Fixed the above problem by changing the method to a different name -- instead of using 'Main' again here in the new class, I just added a 1 to the end of it, and it seems to run fine.
            Console.WriteLine("");//This whole section of code was originally written another method 'Main1' which I never defined, but seemed to run anyway, within another class (same name as the first one)
            Console.WriteLine("There was once a man who liked to walk his dog. What was the name of the man?");//that was also within a differently named name space. Couldn't find a way to run this block of
            string userName = Console.ReadLine();//code after the first one terminated, so I simply copied and pasted all of it up here into the main method, and it will run after the first segment has terminated.
            Console.WriteLine("And what was the name of his dog?");
            string userDogName = Console.ReadLine();
            Console.WriteLine("How old was the dog?");
            string userDogAge = Console.ReadLine();//I noticed that numerical values could be input here by the user, and there was no issue in the script execution, even though the variable type is a string.
            Console.WriteLine("What kind of dog was it?");
            string userDogType = Console.ReadLine();

            Console.WriteLine($"{userName}, a loner from the suburbs of the local area, was a fan of getting in his exercise for the day. To do this he would walk his pup, {userDogName}, around his neighborhood");
            Console.WriteLine($"several times a day, as his {userDogType} was of a more energetic breed, being the ripe age of {userDogAge}.");
            Console.WriteLine("");

            Console.WriteLine("Adding numbers -- start with one number, pick one.");
            int num1 = int.Parse(Console.ReadLine());//For some reason, the 'int' variables num1 and num2 need to be declared again up here, possibly because of the order in which this code is being written.
            //int num1 = Console.ReadLine(); -- Received an error reading, 'Cannot implicitly convert type 'string' to type 'int', meaning that the variable being used here is integer based, not string based.
            Console.WriteLine("Now, select another.");
            int num2 = int.Parse(Console.ReadLine());//These user input lines represent initialization of the variable here, as they haven't necessarily been assigned a value yet.
            //int num2 = Console.ReadLine(); -- Instead of using Console.ReadLine(); implement something else that takes the input of integers, such as 
            int sum = Sum(num1, num2, 4, 6, 14, 27, 38, 42);//Very important -- all methods must be started with a capital letter.... otherwise, the software gets confused as to what it is.
            Console.WriteLine($"The sum of the two numbers you selected is, {sum}");//Already declared what the sum variable was in the line above.
            Console.WriteLine("");
            Console.WriteLine("Multiplying numbers -- start with one number, pick one.");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, select another.");
            int num4 = int.Parse(Console.ReadLine());
            int product = Product(num3, num4);//Unlike the modified Sum method created down below, this method was never updated to take on more than 2 arguments, so attempting to put in more than 2 results in an error.
            Console.WriteLine($"The product of the two numbers you selected is, {product}");//Even if you input less than two values or variables for the above method, an error will still present, because the second value/variable written into the called method's parameter down below isn't being used.
            Console.WriteLine("");
            int sumparams = Sum(4, 6, 14, 27, 38, 42);//can only take however many values were defined in the parameter of the method. So, 'Sum', by itself, could originally only take 2 integers, not as many as it could have.
            Console.WriteLine($"The following is adding a series of inputted numbers, based on parameters -- {sumparams}");//elected no to go with user input here because it would be very time consuming to write out.
        }

        public static int OldSum(int num1, int num2)//This method is publicly available as a class, which means its code is accessible by other methods calling its function, or variables.
        {//This method will have a red squiggly line show up beneath it when it is first being written because it isn't set to return anything yet -- in order to work, it has to return something.
            return num1 + num2;//No longer need to title each variable here with 'int' because they've already been declared.
        }
        public static int Product(int num3, int num4)//Writing out a method in this way is also referred to as a method declaration.
        {//Methods like these can be called and used over and over again, without having to change the names of already used variables.... although I'm curious to know if variables like num1 and num2
            return num3 * num4;//will always use the stored data they received from the under the first time around, in this instance?
        }
        public static int Sum(params int[] list)//Purpose of this method is to be able to implement as many values as we want to.
        {//This written by itself isn't usable as a method, but when combined with another defined method, say like Sum, it becomes useful because it enables the user to input as many values as they want in the parameters.
            int sumparams = 0;//Number of values this method can start with is 0.

            for (int i = 0; i < list.Length; i++)//For loops written in this manner are great for numerically expressing all numbers greater than zero, to the limit of what's allowable in a list.
            {
                sumparams = sumparams + list[i];//sumparams = itself + i++, nonstop, to infinity.
                //sumparams++;
            }
            return sumparams;//without this line of code, the method has an error suggesting that not all paths code return a value, meaning it's expected to return something.
        }//we input a list as the parameter for this method, so we need to ensure it returns a list in the end of its scope.
    }//static void is executable by itself, but it's ok to become familiar with writing in public static void.
}//Here, I'm seeking to explore how different name spaces with the same classes can also call the same main method.
//The purpose of having multiple name spaces would be in favor of organization, and they each would need to be named differently.
//namespace C_Sharp_Revisited_01B//Here, we'll encounter elements of exercises found in the TrueCoders software engineering self paced program, Module 3.
//{//Methods are more efficient means of reusing already written code, rather than writing out multiple references that likely will have their code changed if a user is attempting to reuse the reference.
//    public class Program//Cannot use program twice here, because the solution file already contains a definition for it (Outmoded -- make a new name space first). I added a new name spacer within this solution file, and it made the problem go away -- program can now be used again, as a new class, with any definition.
//    {//Cannot create another method inside of a method (its scope).
//        public static void Main1(string[] args)//Despite having made a new namespace and new class (program), an error still shows up where the class program has 'more than one entry point defined'.
//        {//Fixed the above problem by changing the method to a different name -- instead of using 'Main' again here in the new class, I just added a 1 to the end of it, and it seems to run fine.
//            Console.WriteLine("There was once a man who liked to walk his dog. What was the name of the man?");
//            string userName = Console.ReadLine();
//            Console.WriteLine("And what was the name of his dog?");
//            string userDogName = Console.ReadLine();
//            Console.WriteLine("How old was the dog?");
//            string userDogAge =  Console.ReadLine();
//            Console.WriteLine("What kind of dog was it?");
//            string userDogType =  Console.ReadLine();

//            Console.WriteLine($"{userName}, a loner from the suburbs of the local area, was a fan of getting in his exercise for the day. To do this he would walk his pup, {userDogName}, around his neighborhood");
//            Console.WriteLine($"several times a day, as his {userDogType} was of a more energetic breed, being the ripe age of {userDogAge}.");
//        }
//    }
//}
//public class ProgramOrder//didn't work -- an attempt at getting different namespaces to run one after the other, in order.
//{
//    static void Main2(string[] args)
//    {
//        C_Sharp_Revisited_01A.Program.Run();
//        C_Sharp_Revisited_01B.Program.Run();
//    }
//}