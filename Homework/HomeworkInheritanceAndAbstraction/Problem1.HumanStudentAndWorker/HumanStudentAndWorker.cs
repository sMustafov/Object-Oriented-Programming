using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1.HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov","12as15"),
                new Student("Petur", "Petrov","45sad4"),
                new Student("Georgi", "Georgiev","123ggg"),
                new Student("Maria", "Marinova","789ssd"),
                new Student("Katq", "Petrova","4556aa"),
                new Student("Minka", "Georgieva","78aa8s"),
                new Student("Dragan", "Kirilov","445sa4"),
                new Student("Kirilka", "Ivanova","9878as"),
                new Student("Kiro", "Mitkov","65sd4s"),
                new Student("Ivanka", "Draganova","7878gd"),
            };

            //students.OrderBy(s => s.FacultyNumber).ToList().ForEach(s => Console.WriteLine(s.ToString()));

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan", "Ivanov",1234,8),
                new Worker("Petur", "Petrov",1200,8),
                new Worker("Georgi", "Georgiev",1000,8),
                new Worker("Maria", "Marinova", 444,4),
                new Worker("Katq", "Petrova",1000,12),
                new Worker("Minka", "Georgieva",1360,10),
                new Worker("Dragan", "Kirilov",800,6),
                new Worker("Kirilka", "Ivanova",1000,6),
                new Worker("Kiro", "Mitkov",1550,6),
                new Worker("Ivanka", "Draganova",800,8),
            };
            workers.OrderByDescending(w => w.MoneyPerHour()).ToList().ForEach(w => Console.WriteLine(w.ToString()));
        }
    }
}
