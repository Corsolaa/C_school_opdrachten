//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class CheckBoss
{
	public static void StartCheckBoss()
	{
		Console.WriteLine("Wat is jouw naam:");
		String name = Console.ReadLine();
		if (name == "Bruno")
		{
			Console.WriteLine("Hallo baas!");
		}
		else {
			Console.WriteLine("Hallo bezoeker!");
		}
	}
}
