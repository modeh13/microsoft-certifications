using Session1.CustomExceptions;
using Session1.DataTypes;
using System;

namespace Session1
{
    //DataTypes
    //Condition structures (if, if-else, switch)
    //Control structures (do-while, while, for, foreach, Recursivity)
    //Transfer control (goto, break, return, throw)
    //Handler Exceptions

    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes valueObj = new ValueTypes();
            ReferenceTypes referenceObj = new ReferenceTypes();
            ConditionStructure();
            ControlStructure();
            //Transfer Control: return, goto, break, continue, throw
            Recursivity();
        }

        static void ConditionStructure()
        {
            int i = 0;
            int j = 0;
            
            //j+=1 --> ++j;
            Console.WriteLine($"The value of j is {j++}"); // j = 0
            Console.WriteLine($"The value of j is {j}"); // j = 1
            Console.WriteLine($"The value of j is {++j}"); // j = 2
            Console.WriteLine($"The value of j is {j+=1}"); // j = 3

            //IF
            if (i == 0) Console.WriteLine($"The value of i is {i}");
            ++i;

            //IF-ELSE (IF-IF-ELSE)
            if (i == 0) {
                Console.WriteLine($"The value of i is {i}");
            }
            else if (i == 1) {
                Console.WriteLine($"The value of i is {i}");
            }
            else {
                Console.WriteLine($"The value of i is {i}");
            }

            //SWITCH
            switch (i)
            {
                case 1:                    
                case 2:
                    Console.WriteLine($"The value of i is between 1 and 2 --> {i}");
                    break;
                default:
                    Console.WriteLine($"The value of i is {i}");
                    break;
            }
        }

        static void ControlStructure()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Control Structures (while, do-while, for, foreach)");

            string[] names = { "Fabio", "Rosa", "Fabián", "Germán", "Luisa", "Juan", "Luis" };
            int i = 0;
            
            //DO-WHILE
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("DO-WHILE");
            do
            {
                if (names.Length > 0) {
                    Console.WriteLine($"Name: {names[i]}");
                    ++i;
                }

            } while (i < names.Length);

            //WHILE
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("WHILE");
            i = 0;
            while (i < names.Length) {
                Console.WriteLine($"Name: {names[i]}");
                i++;
            }

            //FOR
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("FOR");
            //Infinite FOR
            //for (; ;) {
            //}
            for (i = 0; i < names.Length; i++) {
                Console.WriteLine($"Name: {names[i]}");
            }

            //FOREACH
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("FOREACH");
            foreach (string name in names) {
                Console.WriteLine($"Name: {name}");
            }
        }

        static void Recursivity()
        {
            int i = 10;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Recursivity");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Factorial de {i} es {Factorial(i)}");
        }

        static int Factorial(int n)
        {
            //Base case
            if (n == 0) {
                return 1;
            }
            else {
                //Recursive Case
                return n * Factorial(n - 1);
            }
        }

        static void Exceptions() {
            try
            {

            }
            catch (DivideByZeroException ex) {
            }
            catch (CustomException ex) {
            }
            catch (Exception ex) {
            }
            finally {
                //This usually segment is used to clean objects and variables.
            }
        }
    }
}