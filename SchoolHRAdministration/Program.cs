


using HRAdministrationAPI;
using static SchoolHRAdministration.Program;

namespace SchoolHRAdministration
{
    public class Program
    {
        public enum EmployeeType
        {
            Teacher, 
            DyputyHeadMaster,
            HeadOfDepartment,
            HeadMester
        }

        public static void Main(String[] args)
        {
            decimal totalOfSalary = 0;
            List<IEmployee> employees = new List<IEmployee>();

            seedData(employees);

            Console.WriteLine($"Total Annul Salary (incloude bouns) :: {employees.Sum(e => e.Salary)} ");
        }

        public static void seedData(List<IEmployee> employees)
        {

            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Ebrahem", "Mohamed", 40000);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Halad", "Ahemad", 40000);

            IEmployee dyputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DyputyHeadMaster, 5, "Mariam", "Mohamed", 50000);

            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Steve", "Jops", 60000 );

            IEmployee HeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMester, 4, "Malak", "Meko", 80000);
            
            employees.Add(teacher1);
            employees.Add(teacher2);
            employees.Add(dyputyHeadMaster);
            employees.Add(headOfDepartment);
            employees.Add(HeadMaster);
            
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

    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, String firstName, String lastName, decimal salary)
        {
            IEmployee employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                    break;
                case EmployeeType.DyputyHeadMaster:
                    employee = FactoryPattern<IEmployee, DyputyHeadMaster>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.HeadMester:
                    employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                    break;
                default:
                    break;
            }
            if(employee != null)
            {
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Salary = salary;
            }
            else
            {
                throw new NullReferenceException();
            }

            return employee;
        }
        
    }



    

}
