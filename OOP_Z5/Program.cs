using System;
using System.Collections.Generic;
using System.IO;


namespace OOP_Z5
{
    using ListTarget = List<Target>;
    class Program
    {

        static void Main(string[] args)
        {
            ListTarget targets = new ListTarget();
            targets = ReadTargetsFromFile("../../../Folder/target.txt");
            Print(targets);
        }

        static ListTarget ReadTargetsFromFile(string line)
        {
            ListTarget targets = new ListTarget();
            var file = File.ReadAllLines(line);
            for(int i=0; i<file.Length; i++)
            {
                string[] delimeters_0 = { "  ", " ", "\t" };
                string[] mas = file[i].Split(delimeters_0, StringSplitOptions.RemoveEmptyEntries);
                targets.Add(ReadTargetFromFile(mas));
            }
            return targets;
        }

        static Target ReadTargetFromFile(string[] target)
        {
            return new Target(double.Parse(target[0]), double.Parse(target[1]));
        }

        static void Print(ListTarget targets)
        {
            foreach(var target in targets)
            {
                target.PrintTarget();
            }
        }
        static double ReadUserCoordinate(string coordinate)
        {
            Console.WriteLine($"Введите координату выстрела {coordinate}");
            return double.Parse(Console.ReadLine());
        }
    }
}
