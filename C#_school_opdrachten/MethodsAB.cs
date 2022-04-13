//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 11 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class MethodsAB
{

	public static void StarMethodsAB()
	{
		MethodsA();
	}

	private static void MethodsA()
	{
		int a = 400;
		Console.Write("Method A: ");
		Console.WriteLine(a);
		MethodsB(a);
		Console.Write("Method A: ");
		Console.WriteLine(a);
		Console.ReadLine();
	}

	private static void MethodsB(int a)
	{
		Console.Write("Method B: ");
		Console.WriteLine(a);
		a = 600;
	}
}
