using HomeWork6;
using HomeWork6.Task1;
using HomeWork6.Task10;
using HomeWork6.Task2;
using HomeWork6.Task3;
using HomeWork6.Task4;
using HomeWork6.Task5;
using HomeWork6.Task6;
using HomeWork6.Task7;
using HomeWork6.Task8;
using HomeWork6.Task9;

while (true)
{
    //Console.WriteLine("Which task between [1-10] you want to run ?");

    //bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
    //if (!choiceValidation) { Console.WriteLine("invalid input !,Try again !"); continue; }
    int choice = ConsoleHelper.ReadInt("Which task between [1-10] you want to run? [0] for leaving : ");
    if (choice == 1)
    {
        Console.WriteLine("***********************************FirstTask***********************************");

        Console.WriteLine("Fibonacci task ");
       
        int n = ConsoleHelper.ReadInt("Please enter n :");
        Console.WriteLine(Fibonacci.Calculate(n));
    }
    else if (choice == 2) 
    {
        Console.WriteLine("***********************************SecondTask***********************************");

        Console.WriteLine("Prime Number :");
       

        int n = ConsoleHelper.ReadInt("please enter n :");
        Console.WriteLine(PrimeNumber.IsPrime(n));

    }
    else if (choice == 3) 
    {
        Console.WriteLine("***********************************ThirdTask***********************************");
        Console.WriteLine("Increase Sequence");
       
        int[] arr = ConsoleHelper.ReadIntArray();
        Console.WriteLine(InSequence.Find(arr));

        
    }
    else if (choice == 4) 
    {
        Console.WriteLine("***********************************FourthTask***********************************");
        
        int[] arr = ConsoleHelper.ReadIntArray();
        int target = ConsoleHelper.ReadInt("What is the Target Number ?");
        bool found = TwoSumSolver.HasTwoSum(arr, target);

        if (found) { Console.WriteLine("yes , there are two numbers with target sum "); }
        else { Console.WriteLine("no , there are no two numbers ."); }


    }
    else if (choice == 5) 
    {
        Console.WriteLine("*******************************FifthTask*************************************");
        Console.WriteLine("Convert Number to words ");
        int number = ConsoleHelper.ReadInt("Give me number between 1 to 9999");
        string words = NumberToWordsConverter.Convert(number);
        Console.WriteLine($"Result: {words}");
    }
    else if (choice == 6)
    {
        Console.WriteLine("*******************************SixthTask*************************************");
        Console.WriteLine("First Unique Char Finder");
        string input = ConsoleHelper.ReadString("Enter a string: ");
        string result = FirstUniqueCharFinder.FindFirstUnique(input);
        Console.WriteLine($"First unique character: {result}");


    }
    else if (choice == 7)
    {
        Console.WriteLine("*******************************SeventhTask*************************************");
        Console.WriteLine("Number Reverser ");
      
        int number = ConsoleHelper.ReadInt("Enter an integer to reverse: ");
        int reversedNumber = NumberReverser.Reverse(number);

        Console.WriteLine($"Reversed: {reversedNumber}");
    }
    else if (choice == 8) 
    {
        Console.WriteLine("******************************EighthTask**************************************");
        Console.WriteLine("Triangle Checker :");
        int[] numbers = ConsoleHelper.ReadIntArray();
        bool canForm = TriangleChecker.CanFormTriangle(numbers);

        Console.WriteLine($"Can form a triangle? {canForm}");


    }
    else if (choice == 9)
    {
        Console.WriteLine("***********************************NinethTask***********************************");
        Console.WriteLine("ParantheseBalancing");
        //Console.Write("Enter parentheses string: ");
        //string input = Console.ReadLine() ?? "";
        string input = ConsoleHelper.ReadString("Enter parentheses string: ");


        bool isBalanced = ParenthesesValidator.IsValid(input);
        Console.WriteLine($"Is balanced: {isBalanced}");

    }
    else if (choice == 10) 
    {
        Console.WriteLine("***********************************TenthTask***********************************");
       
        int[] arr = ConsoleHelper.ReadIntArray();
        Console.WriteLine(MaxOfThree.Find(arr));
    }
    else if (choice == 0 ) { break; }
    else { Console.WriteLine("Number is out of the range try again please !"); }
}