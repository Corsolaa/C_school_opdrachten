//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class ForLoop
{
	public static void StartForLoop()
	{
		Console.Write("Put in a digit:");
		int inputDigit = Int32.Parse(Console.ReadLine());
		int tempDigit = inputDigit + 100;
		while (inputDigit <= tempDigit)
		{
			Console.WriteLine(inputDigit);
			inputDigit += 3 ;
		}
	}
}
