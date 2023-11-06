

namespace Labb8_OOP_GenericCollections
{
    //Class for all things [list] related
    internal class ListManager
    {

        public List<Employee> employees;

        //Constructor
        public ListManager()
        {
            //Makes the list 
            employees = new List<Employee>();

            //makes some employees
            Employee emp1 = new Employee (101, "Parisa", "F", 35000);
            Employee emp2 = new Employee (102, "Bengt", "M", 28000);
            Employee emp3 = new Employee (103, "Astor", "M", 33000);
            Employee emp4 = new Employee (104, "Berit", "F", 34000);
            Employee emp5 = new Employee (105, "Greta", "F", 34000);

            //Adds all to the list
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
        }

        //*****Methods*****

        //Prints employee details, has object as argument
        public void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"{employee.Id}\t{employee.Name}\t{employee.Gender}\t{employee.Salary}");
        }

        //Filters list by gender depending on argument "F" or "M"
        public void PrintGender(string gender)
        {
            //List to hold search result
            List<Employee> result = new List<Employee>();

            string resultType;

            //If argument is M, add all male employees
            if (gender == "M")
            {
                result.AddRange(employees.FindAll(e => e.Gender == "M"));
                resultType = "Men";
            } 
            
            //If not, add all female employess
            else
            {
                result.AddRange(employees.FindAll(e => e.Gender == "F"));
                resultType = "Women";
            }

            //Prints how many is found
            Console.WriteLine($"\n{result.Count} {resultType} found in the list");
            Console.WriteLine("****************************************");
           
            //Prints the details for each employee found
            foreach (var item in result)
            {
                PrintEmployee(item);
            }
        }
    }
}

