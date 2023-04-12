//Creare una classe di helper CalcoliHelper.
//Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
//- Somma di due numeri interi
//- Somma di due numeri double
//- Differenza tra due numeri interi
//- Differenza tra due numeri double
//- Moltiplicazione di due numeri interi
//- Moltiplicazione di due numeri double
//- Valore assoluto di un numero intero
//- Valore assoluto di un numero double
//- Minimo tra due numeri interi
//- Minimo tra due numeri double
//- Massimo tra due numeri interi
//- Massimo tra due numeri double
//Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
//Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).

Console.WriteLine(CalcoliHelper.Sum(4, 6));
Console.WriteLine(CalcoliHelper.Sum(4.25, 5.75));

Console.WriteLine(CalcoliHelper.Division(10, 2));
Console.WriteLine(CalcoliHelper.Division(5.5, 10.5));

Console.WriteLine(CalcoliHelper.Multiplication(4, 6));
Console.WriteLine(CalcoliHelper.Multiplication(4.5, 6.5));

Console.WriteLine(CalcoliHelper.Max(4, 6));
Console.WriteLine(CalcoliHelper.Max(8.59, 3.43));

Console.WriteLine(CalcoliHelper.ConvertToAbsolute(-4));
Console.WriteLine(CalcoliHelper.ConvertToAbsolute(-8.25));

Console.WriteLine(CalcoliHelper.Min(4, 6));
Console.WriteLine(CalcoliHelper.Min(8.59, 3.43));

public class CalcoliHelper
{
    //static methods (non utilizzano gli attributi)
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static double Sum(double num1, double num2)
    {
        return num1 + num2;
    }

    public static int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    public static int Division(int num1, int num2)
    {
        return num1 / num2;
    }

    public static double Division(double num1, double num2)
    {
        return num1 / num2;
    }

    public static int ConvertToAbsolute(int num)
    {
        return num < 0 ? (num * -1) : num; 
    }

    public static double ConvertToAbsolute(double num)
    {
        return num < 0 ? (num * -1) : num;
    }

    public static int Max(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }

    public static double Max(double num1, double num2)
    {
        return num1 > num2 ? num1 : num2;
    }

    public static int Min(int num1, int num2)
    {
        return num1 < num2 ? num1 : num2;

    }

    public static double Min(double num1, double num2)
    {
        return num1 < num2 ? num1 : num2;
    }
}

