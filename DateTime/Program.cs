using System;
namespace DateTimes;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine($"Year is {date.Year}\nMonth is {date.Month}\nDay is {date.Day}\nHour is {date.Hour}\nMinute is {date.Minute}\nSecond is {date.Second}");
        // bool isDate =  DateTime.TryParseExact(out date);
        string[] dateToString =  date.ToString().Split('/',':',' ');
        for(int i = dateToString.Length-1;i>0;i--){
            System.Console.Write(dateToString[i]+"\t");
        }



        //-------------
         DateTime userValue;
         System.Console.WriteLine("\nEnter Date Like yyyy/MM/dd hh:mm:ss tt");
         
         bool isDate =  DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out userValue);
         while(!isDate){
            System.Console.WriteLine("Please Provide Valid Input");
            isDate =  DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out userValue);
         }
         System.Console.WriteLine($"Year is {userValue.Year}\nMonth is {userValue.Month}\nDay is {userValue.DayOfWeek}");
    }
}