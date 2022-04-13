//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class Username
{
	public static void StartUsername()
	{
		Console.WriteLine("Wat is jouw voornaam:");
		String fname = Console.ReadLine();
		Console.WriteLine("Wat is jouw achternaam:");
		String lname = Console.ReadLine();
		String fullname = fname + " " + lname;
		Console.WriteLine("Welkom, " + fullname + "!");
	}
}
