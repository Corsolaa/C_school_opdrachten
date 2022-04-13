//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class BikeOrWalk
{
	public static void StartBikeOrWalk()
	{
		if (NiceWeather())
		{
			if (FlipJoins())
			{
				Console.WriteLine("Then cicle!!!");
			}
			else
			{
				Console.WriteLine("Then walk!!!");
			}
		}
		else
		{
			Console.WriteLine("Watch Netflix...");
		}
	}


	private static bool ChooseYN(String question_text)
	{
		String input = "";
		while (true)
		{
			Console.WriteLine(question_text + ":  (y/n)");
			input = Console.ReadLine().ToLower();
			if (input == "y")
			{
				return true;
			}
			else if (input == "n")
			{
				return false;
			}
		}
	}

	private static bool NiceWeather()
	{
		return ChooseYN("Is it nice weather outside?");
	}

	private static bool FlipJoins()
	{
		return ChooseYN("is flip joining us?");
	}
}