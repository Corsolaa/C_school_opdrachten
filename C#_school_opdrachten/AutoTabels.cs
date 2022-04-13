//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class AutoTabels
{
	private static void PrintTable(int table) {
		int multiplier = 1;
		Console.WriteLine("This is the table of " + table);
		while (multiplier < 11)
		{
			int result = multiplier * table;
			Console.WriteLine(table + " * " + multiplier + " = " + result);
			multiplier++;
		}
	}

	private static void TableOf() {
		Console.WriteLine("Choose the number that you want to know the table of: ");
		String tableNumber = Console.ReadLine();
		int table;
		if (Int32.TryParse(tableNumber, out table))
		{
			PrintTable(table);
		}
		else {
			Console.WriteLine("No valid input!!");
		}
	}

	public static void StartAutoTabels()
	{
		TableOf();
	}
}
