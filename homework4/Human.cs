using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    internal class Human
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public Human()
        {
            name = "Unknown";
            birthYear = DateTime.Now;
        }

        public Human(string name, DateTime birthYear)
        {
            Name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            DateTime date0 = new DateTime(0001, 01, 01);
            return ((date0 +(DateTime.Now - birthYear)).Year) - 1;
        }

        public static Human Input(int i)
        {
            Console.WriteLine($"Enter human {i + 1} name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter human {i + 1} birthyear");
            DateTime birthYear = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
            Human human = new Human(name, birthYear);
            return human;
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Hi, my name is {name} and my birthyear is {DateTime.Parse(birthYear.ToString()).Year} and i am {Age()} years old";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator == (Human a, Human b)
        {
            return a.name == b.name;
        }

        public static bool operator !=(Human a, Human b)
        {
            return a.name != b.name;
        }
    }
}
