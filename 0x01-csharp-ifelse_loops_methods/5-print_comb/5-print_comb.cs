﻿using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 0; number <= 99; number++){
	    	if (number < 99){
		   Console.Write("{0:d2}, ", number);
		} else {
		   Console.WriteLine("{0:d2}", number);
		}
	    }
        }
    }
}
