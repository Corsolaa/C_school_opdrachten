//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class TryParse
{
	public static void IsValid(String getal)
	{
		int result;
		if (Int32.TryParse(getal, out result))
		{
			Console.WriteLine("Gelukt:");
			Console.WriteLine(result);
		}
		else
		{
			Console.WriteLine("Geen geldige invoer!");
		}
	}

	public static void IsValidInt(String getal)
	{
		int result;
		if (Int32.TryParse(getal, out result))
		{
			Console.WriteLine("Gelukt: ");
			Console.WriteLine(result);
		}
		else
		{
			Console.WriteLine("Geen geldige invoer!");
		}
	}

	public static void StartTryParse()
	{
		String getal1 = Console.ReadLine();
		IsValid(getal1);
		String getal2 = Console.ReadLine();
		IsValid(getal2);
		Console.ReadKey();
	}
}
