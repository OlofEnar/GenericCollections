

namespace Labb8_OOP_GenericCollections
{
    //Class for all things [stack] related
    internal class StackManager 
    {

        public Stack<Employee> stack;

        //Constructor
        public StackManager()
        {
            //Makes a new stack
            stack = new Stack<Employee>();
        }

        //*****Methods*****

        //Loops through the list and pushes every employee to the stack
        public void PushEmployees(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                stack.Push(item);
            }
        }

        //Prints employee details, including stack count
        public void PrintEmployeeAndCount(Employee employee)
        {
            Console.Write($"{employee.Id}\t{employee.Name}\t{employee.Gender}\t{employee.Salary}");
            Console.WriteLine($"\t{stack.Count}");
        }

        //Prints the stack
        public void PrintStack()
        {
            //Header
            Console.WriteLine("Print stack");
            Console.WriteLine("****************************************");
            Console.WriteLine($"ID\tNAME\tGENDER\tSALARY\tIN STACK\n");

            //Loops through the stack and prints employee details
            foreach (var item in stack)
            {
                PrintEmployeeAndCount(item);
            }
        }

        //Pops and prints stack
        public void PopAndPrintStack()
        {
            //Header
            Console.WriteLine("\nPop then Print stack");
            Console.WriteLine("****************************************");

            //Loop through stack as long as it as objects
            while (stack.Count > 0)
            {
                //Remove and hold object in variable
                var EmpRemove = stack.Pop();

                //Call method for printing the details
                PrintEmployeeAndCount(EmpRemove);
            }
        }

        //Peeks and prints stack
        public void PeekAndPrint()
        {
            Console.WriteLine("\nPeek then Print stack");
            Console.WriteLine("****************************************");

            var PeekStack = stack.Peek();

            PrintEmployeeAndCount(PeekStack);
            PrintEmployeeAndCount(PeekStack);
        }
    }
}
