using System;

class Aula4
{
    static int num = 10; //variavel Global //Esse int tem que ser static por que o nosso metodo é estetico
    static void Main(string[] args)
    {
        int num2 = 0; //variavel local do main
        Console.WriteLine(num);
    }
    
}