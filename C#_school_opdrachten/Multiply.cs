//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class Multiply
{
	public static void StartMultiply()
	{
		int print = DoMultiply(4, 5);
		Console.WriteLine(print);
	}

	private static int DoMultiply(int numb1, int numb2)
	{
		int result = numb1 * numb2;
		return result;
	}
}
