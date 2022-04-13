//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class BreakAndContinue
{
	public static void StartBreakAndContinue()
	{
		int[] numb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		//StartBreak(numb);
		StartContinue(numb);
	}

	private static void StartBreak(int[] start) 
	{
		Console.WriteLine("Break Method: ");
		for (int i = 0; i < start.Length; i++)
		{
			if (i > 4)
			{
				break;
			}
			Console.WriteLine(start[i]);
		}
	}

	private static void StartContinue(int[] start)
	{
		Console.WriteLine("Continue Method: ");
		for (int i = 0; i < start.Length; i++)
		{
			if (i > 4)
			{
				continue;
			}
			Console.WriteLine(start[i]);
		}
	}
}
