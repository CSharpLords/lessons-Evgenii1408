﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            word = word.ToLower();
            for (int i = 0; i < word.Length; i = i + 1){
                if (word[i] == 'и') {
                     Console.WriteLine("В слове " + word + "есть и");
                     Console.Read();
                     Environment.Exit(0);
               
                    Console.WriteLine(" слове " + word + "буква И не найдена");
                    Console.Read();
                 }
            }
        }   
    }
 }   
