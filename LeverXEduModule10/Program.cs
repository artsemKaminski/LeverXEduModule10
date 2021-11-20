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
                var company = db.Companies.First();

                foreach (var u in company.Users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age} {u.Profile.Address}");
                }
            }
        }

        private static void SetData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.Migrate();
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var userProfile1 = new UserProfile { Address = "tst address"};
                var userProfile2 = new UserProfile { Address = "tst address" };
                var user1 = new User { Name = "Tom", Age = 33, Profile = userProfile1 };
                var user2 = new User { Name = "Alice", Age = 26, Profile = userProfile2 };
                var company = new Company { Name = "LeverX", Users = { user1, user2 } };

                db.Companies.Add(company);
                db.SaveChanges();
                Console.WriteLine("Objects created");


            }
        }
    }
}
