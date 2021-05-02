using Monsters.Models;
using System;
using System.Linq;

namespace Monsters.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Stressen",LastName="dödar",EmailAdress="destress@hotmail.com",PhoneNumber="076-666 66 66",Course="YSYS-OP1"},
            new Student{FirstName="Pizza",LastName="Älskare",EmailAdress="dominos@gmail.com",PhoneNumber="072-000 00 00",Course="YSYS-OP1"},
            new Student{FirstName="Monster",LastName="Huggaren",EmailAdress="monsters@ink.com",PhoneNumber="076-123 45 67",Course="YSYS-OP2"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

        }
    }
}