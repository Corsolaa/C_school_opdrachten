//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;
using System.Collections;

public class DoArrayList
{
	public static void StartDoArrayList()
	{
		ArrayList list = new ArrayList() {"banaan", 1, 1.6, true};
		foreach (var item in list)
		{
			Console.WriteLine(item);
		}
	}
}
