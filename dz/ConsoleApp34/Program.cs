using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    internal class Firm
    {
        public string Name { get; set; }
        public DateTime Founded { get; set; }
        public string Profile { get; set; }
        public string Director { get; set; }
        public int Employees { get; set; }
        public string Address { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firms = new List<Firm>()
            {
                new Firm { Name="RedFox", Founded=new DateTime(2020,5,1), Profile="Marketing", Director="John White", Employees=250, Address="London" },
                new Firm { Name="StarTech", Founded=new DateTime(2023,1,10), Profile="IT", Director="Alex Brown", Employees=80, Address="New York" },
                new Firm { Name="GreenLeaf", Founded=new DateTime(2018,3,15), Profile="Marketing", Director="Peter Black", Employees=120, Address="London" },
                new Firm { Name="MoonFood", Founded=new DateTime(2022,7,20), Profile="Food", Director="Mike White", Employees=40, Address="Berlin" },
                new Firm { Name="BlueSky", Founded=new DateTime(2024,1,1), Profile="IT", Director="Robert Black", Employees=10, Address="Paris" }
            };

            var q1 = from f in firms
                     select f;

            var q2 = from f in firms
                     where f.Name.Contains("Food")
                     select f;

            var q3 = from f in firms
                     where f.Profile == "Marketing"
                     select f;

            var q4 = from f in firms
                     where f.Profile == "Marketing" || f.Profile == "IT"
                     select f;

            var q5 = from f in firms
                     where f.Employees > 100
                     select f;

            var q6 = from f in firms
                     where f.Employees >= 100 && f.Employees <= 300
                     select f;

            var q7 = from f in firms
                     where f.Address == "London"
                     select f;

            var q8 = from f in firms
                     where f.Director.Split(' ')[1] == "White"
                     select f;

            var q9 = from f in firms
                     where (DateTime.Now - f.Founded).TotalDays > 365 * 2
                     select f;

            var q10 = from f in firms
                      where (DateTime.Now - f.Founded).TotalDays == 123
                      select f;

            var q11 = from f in firms
                      where f.Director.Split(' ')[1] == "Black"
                         && f.Name.Contains("White")
                      select f;
        }
    }
}

