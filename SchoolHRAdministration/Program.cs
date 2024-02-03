


using HRAdministrationAPI;

namespace SchoolHRAdministration
{
    public class Program
    {
        public static void Main(String[] args)
        {
            decimal totalOfSalary = 0;
            List<IEmployee> employees = new List<IEmployee>();

            seedData(employees);

            //foreach(IEmployee employee in employees)
            //{
            //    totalOfSalary += employee.Salary;
            //}

            //Console.WriteLine($"Total Annul Salary (incloude bouns) :: {totalOfSalary} ");


            Console.WriteLine($"Total Annul Salary (incloude bouns) :: {employees.Sum(e => e.Salary)} ");
        }

        public static void seedData(List<IEmployee> employees)
        {

            IEmployee teacher1 = new Teacher()
            {
                Id = 1,
                FirstName = "Ebrahem",
                LastName = "Mohamed",
                Salary = 40000,
            };

            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher()
            {
                Id = 2,
                FirstName = "Halad",
                LastName = "Ahemad",
                Salary = 40000,
            };

            employees.Add(teacher2);


            IEmployee headOfDepartment = new HeadOfDepartment()
            {
                Id = 3,
                FirstName = "Steve",
                LastName = "Jops",
                Salary = 50000,
            };

            employees.Add(headOfDepartment);


            IEmployee HeadMaster = new HeadMaster()
            {
                Id = 4,
                FirstName = "Malak",
                LastName = "Meko",
                Salary = 60000,
            };

            employees.Add(HeadMaster);


            IEmployee dyputyHeadMaster = new DyputyHeadMaster()
            {
                Id = 5,
                FirstName = "Mariam",
                LastName = "Mohamed",
                Salary = 80000,
            };

            employees.Add(dyputyHeadMaster);

        }
    }

    public class Teacher : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    public class DyputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class HeadOfDepartment : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }


    public class HeadMaster : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }



    

}
