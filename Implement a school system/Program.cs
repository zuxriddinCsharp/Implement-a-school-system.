namespace Implement_a_school_system_
{
    class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string fullName, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"FullName: {FullName}");
            Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        }
    }
    class Student : Person
    {
        public double AverageGrade { get; set; }
        public int[] ArrayGrade { get; set; }

        public Student(int Id, string FullName, string PhoneNumber)
                       : base(Id, FullName, PhoneNumber)
        {
        }
        public void CalculateAverageGrade()
        {
            if (ArrayGrade.Length > 0)
            {
                double sum = 0;
                foreach (int grade in ArrayGrade)
                {
                    sum += grade;
                }

                AverageGrade = sum / ArrayGrade.Length;
            }
            else
            {
                AverageGrade = 0;
            }
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("ArrayGrade");
            foreach (int arraygrade in ArrayGrade)
            {
                Console.Write(arraygrade + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Average grade: {AverageGrade}");
        }
    }
    class Employee : Person
    {
        public double Salari { get; set; }
        public Employee(int Id, string FullName, string PhoneNumber)
                        : base(Id, FullName, PhoneNumber)
        {
        }
        public void CalculateTax()
        {
            Salari = Salari + (Salari * 0.13);
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Salari: {Salari}");
        }
    }
    class Teacher : Person
    {
        public double HourlyRate { get; set; }
        public Teacher(int Id, string FullName, string PhoneNumber)
                        : base(Id, FullName, PhoneNumber)
        {
        }
        public double CalculateMontlyInco()
        {
            return HourlyRate * 170d;
        }
        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Hourly rate: {CalculateMontlyInco()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1111, "Raximov Zuxriddin", "893-182-09-52");
            student.ArrayGrade = new int[] { 5, 4, 5, 4, 4 };
            student.CalculateAverageGrade();

            Employee employee = new Employee(2222, "Boburjon Egamov", "999-999-99-99");
            employee.Salari = 10000;
            employee.CalculateTax();

            Teacher teacher = new Teacher(3333, "Nodirxonov Boburxon", "888-888-88-88");
            teacher.HourlyRate = 35;
            teacher.CalculateMontlyInco();

            Console.WriteLine("Student information: ");
            student.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Employee information: ");
            employee.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Teacher information: ");
            teacher.DisplayInfo();
            Console.WriteLine();
        }
    }
}