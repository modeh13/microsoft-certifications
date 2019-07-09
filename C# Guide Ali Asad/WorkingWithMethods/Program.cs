namespace WorkingWithMethods
{
   class Program
   {
      static void Main(string[] args)
      {
         int first = Sum(10, 15);

         //Calling a method throught "named parameters"
         int second = Sum(b: 20, a: 20);

         //Using default value to parameters, and it is known "Optional parameters"
         int third = SumOptional(10);
         int fourth = SumOptional(10, 20);

         //Passing a parameter as Reference with "ref" keyword.
         //We are telling to the Program, please use "memory address" and update its value instead of use the value directly.
         int i = 10;
         PassByRef(ref i);

         //Passing a parameter as Reference with "out" keyword.
         int j;
         PassByOut(out j);

         //Passing a multiple parameters
         int result = Sum(10, 2, 3, 4, 5, 6, 7);
      }

      /// <summary>
      /// Method Sum, it makes an adition operation between two integer numbers.
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      private static int Sum(int a, int b)
      {
         return a + b;
      }

      /// <summary>
      /// Method Sum, with default value for the b parameter, and this parameter can be used as Optional parameter
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      private static int SumOptional(int a, int b = 1)
      {
         int add = a + b;
         return add;
      }

      /// <summary>
      /// Using the ref keyword to pass a parameter as Reference
      /// It's necessary to use of "ref" keyword in both method definition and where method is called. 
      /// </summary>
      /// <param name="i"></param>
      private static void PassByRef(ref int i)
      {
         i = i + 1;
      }

      /// <summary>
      /// Using the out keyword to pass a parameter as Reference
      /// It's necessary to use of "out" keyword in both method definition and where method is called.
      /// When we use out keyword, the variable must not be initialized, the initialization should be inside
      /// Method.
      /// </summary>
      /// <param name="i"></param>
      private static void PassByOut(out int j)
      {
         j = 0;

         for(int i = 0; i < 10; i++)
            j += 1;
      }

      /// <summary>
      /// Using the "params" keyword to be able use the array arguments and pass several parameters.
      /// The "params" keyword is required.
      /// - A method shouldn’t have more than one param array.
      /// - If there is more than one parameter, params array should be the last one.
      /// </summary>
      /// <param name="numbers"></param>
      private static int Sum(int i, params int[] numbers)
      {
         int result = 0;
         foreach (int number in numbers)
            result += number;

         return result;
      }
   }
}