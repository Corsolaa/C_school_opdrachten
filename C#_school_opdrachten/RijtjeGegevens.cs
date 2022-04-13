//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class RijtjeGegevens
{
	public static void StartRijtjeGegevens()
	{
		int monthDigit;
		String[] monthList = {"januari", "februari", "maart", "april", 
								"mei", "juni", "juli", "augustus", 
								"september", "oktober", "november", 
								"december"};
		while (true) {
			Console.Write("Welke maand ben je in geboren (cijfer 1 t/m 12): ");
			monthDigit = Int32.Parse(Console.ReadLine());
			if (monthDigit >= 1 && monthDigit <= 12) {
				break;
			}
			Console.WriteLine("Tussen 1 en 12 aub!!!");
		}
		Console.WriteLine("De maand waarin jij geboren bent issss: " + monthList[monthDigit - 1]);
	}
}
