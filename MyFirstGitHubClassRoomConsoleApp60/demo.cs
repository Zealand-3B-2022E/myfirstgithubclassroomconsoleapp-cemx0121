using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class demo
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        public demo(string name, int age, string adress)
        {
            Name = name;
            Age = age;
            Adress = adress;

        }

        public override string ToString()
        {
            return $"Navn: {Name} | Alder: {Age} | Adresse: {Adress}"; 
        }

    }
}
