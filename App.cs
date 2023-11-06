

namespace Labb8_OOP_GenericCollections
{
    internal class App
    {
        //Variable for holding search results
        Employee empCheck;

        //Method that runs all tasks
        public void Run()
        {

            //Instanciate the class with all methods related to stack and list
            StackManager stackManager = new StackManager();
            ListManager listManager = new ListManager();

            //Push all employees to the stack
            stackManager.PushEmployees(listManager.employees);

            //Print the stack
            stackManager.PrintStack();

            //Pop then Print the stack
            stackManager.PopAndPrintStack();

            //Push to the stack again
            stackManager.PushEmployees(listManager.employees);

            //Peek 2x times then print
            stackManager.PeekAndPrint();

            //Check if the stack contains a certain object by its
            //Id property and print to console.
            
            //This should be a method in StackManager but having trouble accessing
            //it without creating a new instance of ListManager.
            empCheck = listManager.employees.Find(e => e.Id == 103);

            if (stackManager.stack.Contains(empCheck))
            {
                Console.WriteLine($"\n{empCheck.Name} is in the stack");
            }
            else
            {
                Console.WriteLine($"{empCheck.Name} has left the stack");
            }

            //Does pretty much the same as above
            //empCheck = listManager.employees.Find(e => e.Gender == "M");
            //listManager.PrintEmployee(empCheck);

            //Calls PrintGender method and takes "F"/"M" as argument
            listManager.PrintGender("M");
        }
    }
}
