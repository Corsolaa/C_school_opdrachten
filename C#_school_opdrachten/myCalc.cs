//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class myCalc
{
    public static void StartMycalc()
    {
        Console.WriteLine("Toets het eerste getal in:   ");
        Double digit1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Toets het tweede getal in:   ");
        Double digit2 = Double.Parse(Console.ReadLine());
        Double result = 0;
        int i;
        String oper = "";
        do
        {
            Console.WriteLine("Wat voor berekening wenst u te doen?(*,/,+,-,%):   ");
            oper = Console.ReadLine();
            i = 0;
            switch (oper)
            {
                case "/":
                    result = digit1 / digit2;
                    break;
                case "*":
                    result = digit1 * digit2;
                    break;
                case "+":
                    result = digit1 + digit2;
                    break;
                case "-":
                    result = digit1 - digit2;
                    break;
                case "%":
                    result = digit1 % digit2;
                    break;
                default:
                    Console.WriteLine("de inputs moeten zijn: *, /, +, -, %");
                    i = 1;
                    break;
            }
        } while (i == 1);
        Console.WriteLine("Hier is het resultaar:");
        Console.WriteLine(digit1.ToString() + " " + oper + " " + digit2 + " = " + result);
    }
}
