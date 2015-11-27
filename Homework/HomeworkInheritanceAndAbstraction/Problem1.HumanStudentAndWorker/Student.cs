using System;

namespace Problem1.HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 && value.Length > 10)
                {
                    throw new ArgumentNullException("The faculty number length should be between 5 and 10 characters");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            string info = String.Format("Student:\nFirst Name: {0}\nLast Name: {1}\nFaculty Number: {2}\n", FirstName,
                LastName, FacultyNumber);
            return info;
        }
    }
}
