using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Add(Dictionary<string, string> d, string login, string pass)
        {
            if (!d.ContainsKey(login))
            {
                d[login] = pass;
                Console.WriteLine($"Added: {login}");
            }
            else
            {
                Console.WriteLine($"Login exists: {login}");
            }
        }

        static void Remove(Dictionary<string, string> d, string login)
        {
            if (d.ContainsKey(login))
            {
                d.Remove(login);
                Console.WriteLine($"Removed: {login}");
            }
            else
            {
                Console.WriteLine($"Login not found: {login}");
            }
        }

        static void Update(Dictionary<string, string> d, string oldLogin, string newLogin, string newPass)
        {
            if (d.ContainsKey(oldLogin))
            {
                d.Remove(oldLogin);
                d[newLogin] = newPass;
                Console.WriteLine($"Updated: {oldLogin} -> {newLogin}");
            }
            else
            {
                Console.WriteLine($"Login not found: {oldLogin}");
            }
        }

        static void GetPass(Dictionary<string, string> d, string login)
        {
            if (d.ContainsKey(login))
            {
                Console.WriteLine($"Password for {login}: {d[login]}");
            }
            else
            {
                Console.WriteLine($"Login not found: {login}");
            }
        }

        static void Main(string[] args)
        {

            Dictionary<string, string> logins = new Dictionary<string, string>();

            Add(logins, "andrii", "12345");
            Add(logins, "dmitrii", "54321");
            Add(logins, "anastasia", "abcd");

            Console.WriteLine();

            GetPass(logins, "andrii");
            GetPass(logins, "anastasia");
            GetPass(logins, "oleg");

            Console.WriteLine();

            Update(logins, "andrii", "andrii_new", "newpass");
            GetPass(logins, "andrii_new");

            Console.WriteLine();

            Remove(logins, "dmitrii");
            GetPass(logins, "dmitrii");

            Console.WriteLine("\nAll logins:");
            foreach (var login in logins.Keys)
            {
                Console.WriteLine($"{login}");
            }
        }
    }
}
