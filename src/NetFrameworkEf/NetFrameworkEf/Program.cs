using NetFrameworkEf.Data;
using NetFrameworkEf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkEf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.CreateIfNotExists();
                context.Users.Add(new UserInfo());
                context.SaveChanges();

                Console.WriteLine("Hello, World!");
            }
        }
    }
}
