using System;

class Program
{
    /*static void Main(string[] args)
    {

        Console.WriteLine(suma(7,5.3));
    }

     static int suma(int operador1, int operador2)=>operador1 + operador2;

     static int suma(int numero1, double numero2) => numero1;
     static int suma(int numero1, int numero2, int numero3,int numero4) => numero1 + numero2+numero3+numero4;
    */

    /*static void Main(string[] args)
    {

        Console.WriteLine(Suma(7, 5.3));
    }
    private static double Suma(int v1, double v2)
    {
        return v1 + v2;
    }*/

    //Valores opcionales

    static void main(string[] args)
    {
        int valor1 = 5;
        double valor2 = 7;
        double valor3 = 2;
        Console.WriteLine(suma(valor1, valor2, valor3));

    }

    static double suma(int num1, double num2, double num3 = 0)
    {
        return num1 + num2 + num3;

    }

    static double suma(int num1, double num2)
    {
        return num1 + num2;

    }


}