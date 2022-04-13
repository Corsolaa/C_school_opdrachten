//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class Optellen
{
	public static void StartOptellen()
	{
		Console.WriteLine("Geef een getal:");
		String digit1 = Console.ReadLine();
		Console.WriteLine("Geef nog een getal:");
		String digit2 = Console.ReadLine();
		int result = Int32.Parse(digit1) + Int32.Parse(digit2);
		Console.WriteLine("Het totaal is:");
		Console.WriteLine(result);
	}
}
