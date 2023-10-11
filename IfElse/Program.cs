using System;


namespace IfElse;

class Program
{
 public static void Main(string[] args)
 {
    // int mark = Convert.ToInt32(Console.ReadLine());
    // if(mark>100 || mark<0){
    //     Console.WriteLine("Invalid Input");
    // }else if(mark > 80 ){
    //     Console.WriteLine("Grade A");
    // }else if(mark > 60){
    //     Console.WriteLine("Grade B");
    // }else if(mark >= 36){
    //     Console.WriteLine("Grade C");
        
    // }else{
    //     Console.WriteLine("Grade D");
    // }
    int limit = Convert.ToInt32(Console.ReadLine());
        int result  = 0;
        for(int i = 1,j =limit;i<=limit ;j--,i++){
            if(i+j == limit){
                result++;
            }
        }
        Console.WriteLine(result);
 }   
}