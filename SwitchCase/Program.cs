using System;
namespace SwitchCase;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Value1");
        
        double value1 ; //= Convert.ToDouble(Console.ReadLine());
        bool isValue1 = double.TryParse(Console.ReadLine(),out value1);

        Console.WriteLine("Enter Value2");
        
        double value2 ;// = Convert.ToDouble(Console.ReadLine());
        bool isValue2 = double.TryParse(Console.ReadLine(),out value2);;
        
        if(!isValue1 || !isValue2){
            Console.WriteLine("Please Provide a Number");
        }

         if(isValue1 && isValue2){
            Console.WriteLine("Enter Which Operation \n + For addition \n - For Subraction \n * For Multiplication \n / For Division \n % For Modulo");
         }
        char operation = Convert.ToChar(Console.ReadLine());
        
        double result=0;
        bool isInvalid = false;

        if(isValue1 && isValue2){
        switch (operation)
        {
            case '+':
                result = value1+value2;
                break;
            case '-':
                result = value1-value2;
                break;
            case '*':
                result = value1*value2;
                break;
            case '/':
                result = Math.Round(value1/value2,2);
                break;
            case '%':
                result = Math.Round(value1%value2,2);;
                break;
            default:
                isInvalid = true;
                Console.WriteLine("---------\nInvalid Operation");
                break;
        }
        }
        if(!isInvalid) {
        Console.WriteLine($"The result is {result}");
        }
        
        

    }

}