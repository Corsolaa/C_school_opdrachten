//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class ForEachLoop
{
	public static void StartForEachLoop()
	{
		int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		int count = 0;
		foreach (int i in numbers)
		{
			count++;
		}
		Console.WriteLine("the number of digits: " + count);
	}
}
