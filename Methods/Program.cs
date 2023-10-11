using System;

public class Program
{
  
  public static void Main(string[] args)
  {
      IsCompleted();
  }

  public static void IsCompleted(){  //WithOut Argument Without Return - Type 1

      bool isComplete = Start(); 
      
      if(isComplete){
        System.Console.WriteLine("Thank You For Using");
      }

  }
  public static bool Start() //Without Argument With Return - Type 2
  {

    string again = "";
    double value1;
    double value2;
    do
    {
      if (again == "yes") break;

      Console.WriteLine("Enter Value1: ");

      bool isValue1 = double.TryParse(Console.ReadLine(), out value1);
      while (!isValue1)
      {
        Console.WriteLine("Please Enter a Valid Number");
        isValue1 = double.TryParse(Console.ReadLine(), out value1);
      }

      Console.WriteLine("Enter Value2: ");

      bool isValue2 = double.TryParse(Console.ReadLine(), out value2);
      while (!isValue2)
      {
        Console.WriteLine("Please Enter a Valid Number");
        isValue2 = double.TryParse(Console.ReadLine(), out value2);
      }

      Console.WriteLine("Which Operation Do You Want To Perform \nAddition for '+'\nSubraction for '-'\nMultiplication for '*' \nDivison for '/'");


      char action;
      bool isCorrectAction = char.TryParse(Console.ReadLine(), out action);

      Action(action, value1, value2, isCorrectAction);


      Console.WriteLine("Do You Want to Quit  Yes or No ?");
      again = Console.ReadLine().ToLower();


      if (again != "yes" && again != "no")
      {
        do
        {
          if (again == "no" || again == "yes") break;

          Console.WriteLine("Please Type Yes or No");

          again = Console.ReadLine().ToLower();

        } while (again != "yes" || again != "no");
      }

    } while (again != "yes");
    return true;
    
  }
  public static void Action(char action, double value1, double value2, bool isCorrectAction) //Type 2 -  With argument Without Return 
  {
    switch (action)
    {
      case '+':
        double ans = Addition(value1, value2);
        Console.WriteLine(ans);

        break;
      case '-':
        double sub = Subraction(value1, value2);
        Console.WriteLine(sub);

        break;
      case '*':
        double mull = Multiplication(value1, value2);
        Console.WriteLine(mull);

        break;
      case '/':
        double div = Division(value1, value2);
        Console.WriteLine(div);

        break;
      default:
        while (action != '+' && action != '/' && action != '*' && action != '-')
        {
          System.Console.WriteLine("Enter Correct Action");
          isCorrectAction = char.TryParse(Console.ReadLine(), out action);
        }
        Action(action, value1, value2, isCorrectAction);
        break;
    }
  }
  public static double Addition(double number1, double number2) //Type 3 - With Argument With Return 
  {
    return number1 + number2;
  }
  public static double Subraction(double number1, double number2)
  {
    return number1 - number2;
  }
  public static double Multiplication(double number1, double number2)
  {
    return number1 * number2;
  }
  public static double Division(double number1, double number2)
  {
    return number1 / number2;
  }

}
