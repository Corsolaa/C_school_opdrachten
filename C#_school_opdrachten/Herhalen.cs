//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class Herhalen
{
	public static void StartHerhalen()
	{
		int digit1 = askDigit1();
		int digit2 = askDigit2(digit1);
		while (digit1 <= digit2) {
			Console.WriteLine(digit1);
			digit1++;
		}
	}

	private static int askDigit1() {
		int digit;
		Console.Write("Vanaf welk getal wil je beginnen: ");
		digit = Int32.Parse(Console.ReadLine());
		return digit;
	}

	private static int askDigit2(int digit2)
	{
		int digit;
		while (true)
		{
			Console.Write("Tot welk getal wil je het hebben: ");
			digit = Int32.Parse(Console.ReadLine());
			if (digit2 < digit)
			{
				break;
			}
			Console.WriteLine("Getal is niet kleiner dan het eerste getal...");
		}
		return digit;
	}
}
