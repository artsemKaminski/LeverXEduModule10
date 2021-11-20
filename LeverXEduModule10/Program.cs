using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LeverXEduModule10
{
    class Program
    {
        static void Main(string[] args)
        {
            SetData();
            GetData();
        }

        private static void GetData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var company = db.Companies.Include(x => x.Users).First();
                
                foreach (var u in company.Users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }

        private static void SetData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.Migrate();

                var user1 = new User { Name = "Tom", Age = 33 };
                var user2 = new User { Name = "Alice", Age = 26 };
                var company = new Company { Name = "LeverX", Users = { user1, user2 } };

                db.Companies.Add(company);
                db.SaveChanges();
                Console.WriteLine("Objects created");


            }
        }
    }
}
