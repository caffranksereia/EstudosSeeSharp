using System;

class Subtracao
{
    static void Main(string[] args){
        Console.WriteLine("Enter com um number");
        int sub1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundo numebro");
        int sub2 = Convert.ToInt32(Console.ReadLine());

        int result;
        result = sub1 - sub2;
        Console.WriteLine("resultado"+result);
    }
}