using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHasherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = "123456";

            var hasher = new PasswordHasher<object>();
            var hashedPassword = hasher.HashPassword(null, password);

            Console.WriteLine($"Hashed Password for {password} is : {hashedPassword}");
            Console.ReadLine();
        }
    }
}