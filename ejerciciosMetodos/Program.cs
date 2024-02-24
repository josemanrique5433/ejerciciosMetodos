using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(suma(7,5.3));
    }

     static int suma(int operador1, int operador2)=>operador1 + operador2;

     static int suma(int numero1, double numero2) => numero1;
     static int suma(int numero1, int numero2, int numero3,int numero4) => numero1 + numero2+numero3+numero4;


}