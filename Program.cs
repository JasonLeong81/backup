using System; // System namespace provide us with console.writeline, write, etc ... 
using testing;
using System.IO;  // include the System.IO namespace bto enable us to work with files
using System.Collections.Generic; // For Lists, 


namespace ConsoleApp1
{
    class Program
    {
        enum year // enums can't in the main function? 
        {
            // items of the enum
            January, // 0
            February, // 1
            March, // 2
            April,
            May=100, // 100
            June // 101
        }
        public static int plus(int a, int b)
        {
            // Console.WriteLine(Car.t()); // The reason is simple: a static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.
            Car c = new Car();
            c.Name = "not random";
            Console.WriteLine(c.Name); // can only reference if it is public static (not really, read comment above)
            Console.WriteLine(c.t());

            Blue bl = new Blue();
            Console.WriteLine(bl.Name);
            Console.WriteLine(bl.t());


            return a + b;
        }
        public static string plus(string a, string b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            /* Multi-line comment */
            // C# is run on the .Net Framework
            // namespace is used to organize your code, and it is a container for classes and other namespaces.
            // Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text.
            // class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.

            Console.WriteLine("Hello World!");
            int a = 5;
            Console.WriteLine(a + 5);
            Console.Write("hello"); // doesn't add a new line 
            Console.Write("world\n");

            // Types of variables -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // int, double, char, string, bool 
            int myNum;
            myNum = 15;
            Console.WriteLine(myNum);

            const int x = 15;
            //x = 20; // error. You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.

            // Data Types -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            /* 
            int 4 bytes 
            long 8 bytes 
            float 4 bytes 
            double 8 bytes 
            bool 1 bit 
            char 2 bytes 
            string 2 bytes per character
            decimal 16 bytes 
             */
            float x1 = 5.75F; // F for float and D for double
            Console.WriteLine(myNum);

            bool isCSharpFun = true;

            // Casting -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Implicit casting (small to large, automatic)
            // Explicit casting (large to small, manual)
            int x2 = 9;
            double myDouble = x2;       // Automatic casting: int to double
            double x3 = 9.78;
            int myInt = (int)x3;    // Manual casting: double to int



            // User Input -------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            // Operators -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // +, -, *, /, 5, ++, --, &&, ||, !, 


            //  Strings -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            string x4 = "Hello World";
            Console.WriteLine(x4.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(x4.ToLower());   // Outputs "hello world"

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}"; // string formatting 
            Console.WriteLine(name);
            Console.WriteLine(name[0]);
            // Escape characters: \', \", \\



            //  if else -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            string result = (time < 18) ? "Good day." : "Good evening."; // ternary operator 
            Console.WriteLine(result);



            //  Switch -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //  while loop -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //  for loop -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string k in cars)
            {
                Console.WriteLine(k);
            }
            //  Break and continue -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // same as python 

            //  Arrays -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            string[] c = { "Volvo", "BMW", "Ford", "Mazda" }; // has methods like: Max, Min, Sum 
            Console.WriteLine(c[0]);
            c[0] = "Opel";
            Console.WriteLine(c[0]);
            Console.WriteLine(c.Length);
            Array.Sort(c);
            for (int ii = 0; ii < cars.Length; ii++)
            {
                Console.WriteLine(cars[ii]);
            }

            // you should note that if you declare an array and initialize it later, you have to use the new keyword:

            string[] t;
            t = new string[] { "Volvo", "BMW", "Ford" };

            //  Methods Parameters -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Static classes are sealed, one cannot inherit a static class from another class. 

            static void test(int age, string country = "Norway") // args before kwargs, same as python 
            {
                Console.WriteLine(country);
            }

            test(10);

            //  Method overloading -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // With method overloading, multiple methods can have the same name with different parameters:
            // Multiple methods can have the same name as long as the number and/or type of parameters are different.

            int t1 = plus(1, 1);
            string t2 = plus("hello", "world");
            Console.WriteLine($"{t1}{t2}");

            //  Enum -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            year yy = year.April;
            int y = (int) year.April;
            Console.WriteLine(y);
            Console.WriteLine(yy);

            //  Files -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            /*
             File methods: AppendText, Copy, Create, Delete, Exissts, ReadAllText, Replace, WriteAllText 
             */
            string writeText = "Hello World!";
            File.WriteAllText("test.txt", writeText); // File location: C:\Users\jason.leong\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\netcoreapp3.1\test.txt
            string readText = File.ReadAllText("test.txt");
            Console.WriteLine(readText);

            //  Exceptions -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // The finally statement lets you execute code, after try...catch, regardless of the result
            // The throw statement allows you to create a custom error. 
            // The throw statement is used together with an exception class. There are many exception classes available in C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc
            Console.WriteLine("\n");
            try
            {
                int[] n = { 1, 2, 3 };
                //Console.WriteLine(n[0]);
                // Console.WriteLine(n[10]); // uncommen this to see error 
                if(1 == n[1]){
                    throw new ArithmeticException("Access denied."); // (Difference between throw, throw new, and throw new Exception(e.Message)) https://stackoverflow.com/questions/2999298/difference-between-throw-and-throw-new-exception
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("Done!");
            }

            // Nullable types (eg  int? x = null;) -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            string str = null; // only used with strings? 
            str ??= "Hello World";
            Console.WriteLine(str);
            int? xx = null, yx = null, zx = null;
            xx ??= yx ??= zx ??= 5;

            Console.WriteLine($"{xx}{yx}{zx}"); // these are nullable types 

            // Lists (Documentation) https://www.tutorialsteacher.com/csharp/csharp-list -------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Use the AddRange() method to add all the elements from an array or another collection to List.
            // Use the Insert() method inserts an element into the List<T> collection at the specified index. Insert() signature: void Insert(int index, T item);
            // Remove(), RemoveAt() 
            // Contains (ie numbers.Contains(10))

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            

            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            //var students = new List<Student>() {
            //    new Student(){ Id = 1, Name="Bill"},
            //    new Student(){ Id = 2, Name="Steve"},
            //    new Student(){ Id = 3, Name="Ram"},
            //    new Student(){ Id = 4, Name="Abdul"}
            //};

            ////get all students whose name is Bill
            //var result = from s in students
            //             where s.Name == "Bill"
            //             select s;

            //foreach (var student in result)
            //    Console.WriteLine(student.Id + ", " + student.Name);
            // Tuple -------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Tuple<string> tup = new Tuple<string>("Jason"); // very cumbersome 
            Console.WriteLine(tup);
            var xxx = Tuple.Create("jason", 1, true); // easily done 
            Console.WriteLine(xxx);

            // HashSet -------------------------------------------------------------------------------------------------------------------------------------------------------------------------



            // Dictionary -------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------



            // Notes -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // && (and), or (||), 
            // this is the same as self in python 
            // var lets the compiler decides on what type the data should be 
            // 
            // global : It's a sometime-necessary prefix indicating the root namespace. It's often added to generated code to avoid name clashes with user code. For example, imagine you had a class called System, but then you wanted to use System.String.You could use global::System.String to differentiate.



            //  Questions -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // lambda, deployment, indexers, await and sync, static and debugging, nameof expressions?, generics?, date and time, structs, delegates, reflection, garbage collector, appending to arrays all other data types. 
            // typeof, LINQ 

        }
    }
}   

    
    
