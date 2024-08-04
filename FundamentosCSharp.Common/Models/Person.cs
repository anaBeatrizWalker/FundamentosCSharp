using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Common.Models
{
    public class Person
    {
        public string Name { get; set; } //atalho: "prop" + tab

        public int Age { get; set; }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello World! My name is {Name} and i have {Age} years old.");
        }
    }
}