//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;

public class Format
{
	public static void StartFormat()
	{
		String today = DateTime.Now.ToString("yyy'-'MM'-'dd");
		Console.WriteLine(today);
	}
}
