//*		 |\__/,|    (`\
//*	   _.|o o  | _   ) )
//*	-(((---(((--------
//*
//* Made by : Corsolaa
//* Date    : 13 / 04 / 2022
//* * * * * * * * * * * * * *
using System;
using System.Threading;

public class DoRandom
{
	public static void StartDoRandom()
	{
		int move = 10;
		bool flip = false;
		while (true) {
			while (flip == false)
			{
				print(move);
				move++;
				if (move == 20)
				{
					flip = true;
				}
			}
			while (flip == true)
			{
				print(move);
				move--;
				if (move == 10)
				{
					flip = false;
				}
			}
		}
		/*Random rnd = new Random();
		int move;
		int i = 0;
		while (i <= 100)
		{
			i++;
			move = rnd.Next(0, 120);
			print(move);
		}*/
	}

	private static void print(int move)
	{
		Thread.Sleep(50);
		String str = new String(' ', move) + "X";
		Console.WriteLine(str);
	}
}
