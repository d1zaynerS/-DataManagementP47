using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Money
    {
        private int wholePart;
        private int fractionalPart;

        public Money(int whole, int fractional)
        {
            SetMoney(whole, fractional);
        }

        public Money() : this(0, 0) { }

        public void SetMoney(int whole, int fractional)
        {
            if (whole >= 0)
            {
                this.wholePart = whole;
            }
            if (fractional >= 0)
            {
                this.wholePart += fractional / 100;
                this.fractionalPart = fractional % 100;
            }
        }

        public override string ToString()
        {
            return $"{wholePart}.{fractionalPart:D2}";
        }

        protected int GetTotalCents()
        {
            return wholePart * 100 + fractionalPart;
        }

        protected void SetFromTotalCents(int totalCents)
        {
            if (totalCents < 0) totalCents = 0;
            this.wholePart = totalCents / 100;
            this.fractionalPart = totalCents % 100;
        }
    }

    class Product : Money
    {
        public string Name { get; set; }

        public Product(string name, int wholePrice, int fractionalPrice)
            : base(wholePrice, fractionalPrice)
        {
            Name = name;
        }

        public Product() : base()
        {
            Name = "Unspecified Product";
        }

        public void DecreasePrice(int wholeAmount, int fractionalAmount)
        {
            int currentCents = GetTotalCents();
            int decreaseCents = wholeAmount * 100 + fractionalAmount;

            int newCents = currentCents - decreaseCents;

            SetFromTotalCents(newCents);

            Console.WriteLine($"Price of {Name} decreased by {wholeAmount}.{fractionalAmount:D2}");
        }

        public override string ToString()
        {
            return $"Product: {Name} | Price: {base.ToString()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Testing Money class:");
            Money lunchCost = new Money(5, 75);
            Console.WriteLine($"Initial Money: {lunchCost}");

            lunchCost.SetMoney(10, 5);
            Console.WriteLine($"New Money: {lunchCost}");

            lunchCost.SetMoney(2, 150);
            Console.WriteLine($"Money with overflow: {lunchCost}");
            Console.WriteLine("------------------------------------------");


            Console.WriteLine("Testing Product class:");
            Product laptop = new Product("Laptop Pro", 1200, 99);
            Console.WriteLine($"1. Initial: {laptop}");

            laptop.DecreasePrice(50, 50);
            Console.WriteLine($"2. After decrease (50.50): {laptop}");

            laptop.DecreasePrice(1200, 0);
            Console.WriteLine($"3. After large decrease (1200.00): {laptop}");
        }
    }
}
