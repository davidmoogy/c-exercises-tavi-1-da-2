using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello world");
        Console.WriteLine(1);

        Console.WriteLine(3+5);
        Console.WriteLine(5-3);

        void Print(string name) {
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("hello " + name);
        }
        Print("dato");

        string textt = "abcdferrf";
        Console.WriteLine(textt.Length);

        string strqion1 = "good morning";
        string striqoni2 = "good evenig";

        string merged = strqion1 + " " +  striqoni2;

        string lowercase = strqion1.ToLower();
        string upercase = striqoni2.ToUpper();

        Console.WriteLine(merged);
        Console.WriteLine(lowercase);
        Console.WriteLine(upercase);


        Console.WriteLine("Enter yout username : ");
        string username = Console.ReadLine();

        Console.WriteLine(username.ToLower(), username.ToUpper());


        Console.WriteLine("Enter text something t oshow lenght of your text and get four symbols ");
        string Textt = Console.ReadLine();
        Console.WriteLine(Textt.Length);
        Console.WriteLine(Textt.Substring(0, 4));

        int a = 50;
        int b = 100;
        Console.WriteLine(a);
        Console.WriteLine(b);

        double num1 = 12.34;
        double num2 = 24.13;
        double sum = num1 * num2;
        Console.WriteLine(sum);

        char symbol = 'A';

        Console.WriteLine(char.IsDigit(symbol));

        bool online = true;
        Console.WriteLine(!online);

        Console.WriteLine("sheiyvanet winadadeba : ");
        string winadadeba = Console.ReadLine();
        Console.WriteLine("Sheiyvanot sityva : ");
        string sityva = Console.ReadLine();

        Console.WriteLine(winadadeba.Contains(sityva));

        string updatedString = winadadeba.Replace(" ", "-");
        Console.WriteLine(updatedString);

        double ricxvi = 4;
        double root = Math.Sqrt(ricxvi);

        double gaormagebuli = ricxvi * 2;



    }
}
