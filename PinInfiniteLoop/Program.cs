﻿using System;

namespace PinInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti!";
            //katsete arv on piiramatu.

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN koodi {i} korda sisestanud.");
                }
            }

            Console.WriteLine("Kena päeva!");




        }
    }
}