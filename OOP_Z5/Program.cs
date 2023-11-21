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
            CheckUserShot(targets);
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
            int number = 1;
            foreach(var target in targets)
            {
                Console.Write($"{number} ");
                target.PrintTarget();
                number++;
            }
        }

        static void CheckUserShot(ListTarget targets)
        {
            int number = ReadUserChoice();
            Wind wind = ReadWindFromKeyboard();
            Shot shot = ReadShotFromKeyboard();
            Sustainability sustainability = new Sustainability(0, 0);
            Console.WriteLine(targets[number-1].Shot(wind,sustainability,shot));
        }
        static Wind ReadWindFromKeyboard()
        {
            double x = ReadUserCoordinate("Введите координату ветра x");
            double y = ReadUserCoordinate("Введите координату ветра y");
            return new Wind(x, y);
        }

        static Shot ReadShotFromKeyboard()
        {
            double x = ReadUserCoordinate("Введите координату выстрела x");
            double y = ReadUserCoordinate("Введите координату выстрела y");
            return new Shot(x, y);
        }

        static int ReadUserChoice()
        {
            Console.WriteLine("Введите номер мешени");
            return int.Parse(Console.ReadLine());
        }
        static double ReadUserCoordinate(string text)
        {
            Console.WriteLine(text);
            return double.Parse(Console.ReadLine());
        }
    }
}
