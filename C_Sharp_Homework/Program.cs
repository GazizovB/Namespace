using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Person = C_Sharp_Homework.User;
using Printer = System.Console;

namespace C_Sharp_Homework
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Lesson";
            Printer.WriteLine(person.name);

            Console.ReadLine();
        }
    }

    class User
    {
        public string name;
    }
}


