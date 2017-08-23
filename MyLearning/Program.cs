/*using key word in C# is being used as a directive and as a statement which facilitates correct use of IDisposable objects(for effective memory management). 
 * using key word below is being used as directive to use type from namespace and one will not have to qualify the full name. (Please refer following code for example)
 */

using System;

/*namespace keyword is used in c# two seperate one set of names from another, for organizing class names effectively. 
 * (The class name declared in one namespace would not conflict with the same class name declared in another namespace)
 */
namespace MyLearning
{
    //internal and private word used below are access modifiers, more explanation will be provided in the coming sample programs
    internal class Program
    {
        /* static is keyword used to declare static types, when ever you declare a method with static word. that method can be accesible directly at class level without creating an instance for the class.
         * void keyword in C# indicates the method return type. when a method is declared with void keyword it doesn't return a value
         * Main method used below is the entry point for this application, every C# Executable application has a Main method which is entry point for every application  */
        private static void Main(string[] args)
        {
            /* new key word is used to create a new instance for a Class in C# called as Object, using this Object we can access methods inside the class.
             * below "empObj" is the object been created for the class "Employee"
             * If you type "empObj." intellisense will bring list of all non-static methods of the class "Employee"
             */
            Employee empObj = new Employee();
            empObj.EmployeeDetails();
            empObj.DisplayEmployeeDetails();


            // Below we access static method "EmployeeStaticMethod" using Class Name "Employee" directly, without using Object "empObj"
            Employee.EmployeeStaticMethod();


            /*Console.WriteLine writes the data to the standard out put stream followed by the current line terminator
             * Console.ReadKey waits to get next character or function key pressed by the user at the console.
            */
            Console.WriteLine("Hello world!!!");
            Console.ReadKey();
        }
    }


    // Sample class for understanding basics of class, variables, method declaration, class instantiation and accessing method using class instance 
    internal class  Employee
    {
        //below variables has been declared with appropriate datatypes, data types in C# indicates what kind of value that variable can store and hold. 
        int employeeId;
        string employeeName;
        decimal employeeSalaryPerAnnum;


        //Method below initializes the values for above variables, you will see efficient ways of initializing values in next projects using constructors.
        public void EmployeeDetails()
        {
            employeeId = 123;
            employeeName = "Bob";
            employeeSalaryPerAnnum = 97300;
        }


        // Method below simply Prints all employee details on to console
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Name of Employee is: {0}", employeeName);
            Console.WriteLine("ID of Employee is: {0}", employeeId);
            Console.WriteLine("Salary of Employee is: {0}", employeeSalaryPerAnnum);
            Console.ReadKey();
        }


        //This method below is declared as a static method and can be accessed directly using class name without creating an instance
        public static void EmployeeStaticMethod()
        {
            Console.WriteLine("This is a static method, can be accessed directly from class level");
            Console.ReadKey();
        }

    }
}
