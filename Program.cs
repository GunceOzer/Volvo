using CalculatorApp;

// Creating a instance of class 
Calculator calculator = new Calculator();
// to get input from 
string continueOrStop;
do
{
    try
    {
        Console.WriteLine(
            "Please enter the two numbers you want to make operation(Don't forget to use space between the numbers)");
        //getting the input from the user as a string
        string input = Console.ReadLine();
        // splitting the input and hold it in a string array 
        string[] splitInput = input.Split(' ');
        if (splitInput.Length != 2) // if the input is more than or less than 2 it shows a message and gets the input again
        {
            Console.WriteLine("Invalid input. Please enter exactly 2 numbers seperated by a space");
            input = Console.ReadLine();
            splitInput = input.Split(' ');
        }

        // converting the string array into an integer array to make calculations
        int[] array = Array.ConvertAll(splitInput, int.Parse);
        // for make factorial calculation it holds the first value of the array 
        int forFactorial = array[0];


        Console.WriteLine(
            "Please choose the operation you want to do \n1-Addition\n2-Multiplication\n3-Division\n4-Substraction\n5-Exponentiation\n6-Factorial\n");
        // getting input from user for choosing the operation 
        string chooseOperation = Console.ReadLine();

        switch (chooseOperation)
        {
            case "1":
                Console.WriteLine(calculator.Addition(array));
                break;
            case "2":
                Console.WriteLine(calculator.Multiplication(array));
                break;
            case "3":
                Console.WriteLine(calculator.Division(array));
                break;
            case "4":
                Console.WriteLine(calculator.Substraction(array));
                break;
            case "5":
                Console.WriteLine(calculator.Exponentiation(array));
                break;
            case "6":
                Console.WriteLine(calculator.Factorial(forFactorial));
                break;
            default:
                Console.WriteLine("You entered wrong input");
                break;

        }
    }
    catch(Exception ex) // catches any exceptions that may occur during the execution
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    
    Console.WriteLine("Do you want to continue press Y, if you don't press any key to exit)");
    // getting input from the user if they want to continue to operations or exit the program 
    continueOrStop = Console.ReadLine().ToLower(); // toLower is to make input lowercase
}
while (continueOrStop == "y"); // continues the loop if user enters y or Y 

