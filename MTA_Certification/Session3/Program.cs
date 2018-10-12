using System;
using System.Collections;
using System.Collections.Generic;

namespace Session3
{
   //Session 3 -- DATA STRUCTURES
   class Program
   {
      static string[] Names = { "Fabián", "Germán", "Fabio", "Rosa", "Luisa", "Juan", "Jenny", "Luis" };

      static void Main(string[] args)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Welcome to Session 3 -- DATA STRUCTURES");
         Console.WriteLine(new string('-', 50));

         //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
         //1-) Arrays (Unidimensional and Bidimensional)         
         WorkingWithArrays();

         //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
         //2-) Queue (FIFO - First In First Out)
         WorkingWithQueues();

         //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
         //3-) Stack (LIFO - Last In First Out)
         WorkingWithStack();

         //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
         //4-) LinkedList         
         WorkingWithLinkedList();

         //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
         //5-) Sort Algorithm
         BubbleSortAlgorithm();
         QuickSortAlgorithm();

         //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
         //6-) Understanding "yield" reserved word.
         WorkingWithYieldWord();

         Console.ReadKey();
      }

      protected static void WorkingWithArrays()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with Arrays (ArrayList)");
         //Homogeneity (data with same type) and fixed size
         //Has very fast performance.
         int[] numbers; //STACK --> null

         //HEAP -- > Initialize the Array with the memory address of the first element.
         numbers = new int[4]; //N contiguous spaces reserved
         numbers[0] = 2; //Assign operation.
         int firstValue = numbers[0]; //Access operation

         //ArrayList class (.NET 2.0) is practically deprecated in favor of List<T>
         //Similar or a bit less performance than ARRAYS
         //Supports dynamic size.
         //Supports different data types (Heterogeneous).
         ArrayList numbersList = new ArrayList(); //More slow than ARRAYS
         numbersList.Add(2); //Assign operation
         numbersList.Add("GERMÁN");

         firstValue = (int)numbersList[0];
         string userName = numbersList[1].ToString();
      }

      protected static void WorkingWithQueues()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with Queues");
         //Supports dynamic size.
         //Supports different data types (Heterogeneous).
         //When add a new element and the QUEUE size is inferior, automatically the size is updated.
         Queue queue = new Queue(2);
         queue.Enqueue("Fabio");
         queue.Enqueue("Rosa");
         queue.Enqueue("Fabián");
         queue.Enqueue("Germán");
         queue.Enqueue("Luisa");
         queue.Enqueue("Juan Pablo");
         queue.Enqueue("Luis Fernando");
         queue.Peek(); //Return the object at beginning of the QUEUE without removing it.
         queue.Dequeue(); //Removes and returns the object at beginning of the QUEUE.         

         //System.Collections.Generic
         //Homogeneity (data with same type).
         Queue<string> queueNames = new Queue<string>();
         queueNames.Enqueue("First name");
         queueNames.Enqueue("Second name");
         queueNames.Contains("Third name");
      }

      protected static void WorkingWithStack()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with Stack");
         //Supports dynamic size.         
         //Supports different data types (Heterogeneous).
         Stack stack = new Stack();
         stack.Push("Fabio");
         stack.Push("Rosa");
         stack.Push(1957);
         stack.Push(1968);
         stack.Peek();
         stack.Pop();

         //System.Collections.Generic
         //Homogeneity (data with same type).
         Stack<string> stackNames = new Stack<string>();
         stackNames.Push("First name");
         stackNames.Push("Second name");
         stackNames.Contains("Third name");

         //Example
         Stack<int> numbers = new Stack<int>();
         numbers.Push(2);
         numbers.Push(4);
         numbers.Push(6);
         numbers.Push(8);
         numbers.Pop();
         numbers.Push(3);
         numbers.Pop();
         numbers.Push(4);
         numbers.Push(6);
         numbers.Push(7);
         numbers.Pop();
         numbers.Pop();
         numbers.Pop();
         Console.WriteLine("The TOP element is : " + numbers.Peek());
      }

      protected static void WorkingWithLinkedList()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with LinkedList");
         //Supports dynamic size.
         //Homogeneity (data with same type).
         LinkedList<string> listNames = new LinkedList<string>();
         listNames.AddFirst("Fabio");
         listNames.AddLast("Rosa");
         listNames.AddBefore(listNames.First, "Familia");
         listNames.AddAfter(listNames.Last, "Fabián");
         listNames.RemoveLast();
         listNames.RemoveFirst();
         listNames.Remove("Familia");
      }

      protected static void BubbleSortAlgorithm()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Bubble Sort Algorithm");
         //Algorithm cost is (N - 1) iterations.
         //int[] numbers = new int[10];
         int[] numbers = { 20, 15, 10, 5, 25, 40, 30, 35, 60, 45 };

         Console.WriteLine("Array numbers: " + string.Join(',', numbers));

         if (numbers.Length > 2)
         {
            byte movesCount;

            do
            {
               int a, b;
               movesCount = 0;

               for (byte i = 0; i < numbers.Length - 1; i++)
               {
                  a = numbers[i];
                  b = numbers[i + 1];

                  if (a > b)
                  {
                     numbers[i] = b;
                     numbers[i + 1] = a;
                     movesCount++;
                  }
               }
            } while (movesCount > 0);

            Console.WriteLine("Array numbers sorted: " + string.Join(',', numbers));
         }
      }

      protected static void QuickSortAlgorithm()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Quick Sort Algorithm");
         Random random = new Random();
         byte n = 20;
         int[] numbers = new int[n];

         for (byte i = 0; i < n; i++)
         {
            numbers[i] = random.Next(0, 100);
         }

         Console.WriteLine("Array numbers: " + string.Join(',', numbers));
         numbers = QuickSort(numbers, 0, numbers.Length - 1);
         Console.WriteLine("Array numbers sorted: " + string.Join(',', numbers));
      }

      protected static int GetNewPivote(int[] numbers, int left, int right, int pivotIndex)
      {
         int pivoteValue = numbers[pivotIndex];

         //Move pivote to end position
         int rightValue = numbers[right];
         numbers[right] = numbers[pivotIndex];
         numbers[pivotIndex] = rightValue;

         //newPivot storages the index for the first more bigger value than PIVOT
         int newPivot = left;
         int tempValue;

         for (int i = left; i < right; i++)
         {
            if (numbers[i] <= pivoteValue)
            {
               tempValue = numbers[newPivot];
               numbers[newPivot] = numbers[i];
               numbers[i] = tempValue;
               newPivot++;
            }
         }

         tempValue = numbers[right];
         numbers[right] = numbers[newPivot];
         numbers[newPivot] = tempValue;

         return newPivot;
      }

      protected static int[] QuickSort(int[] numbers, int left, int right)
      {
         //20, 10, 35, 5, 15, 22, 40, 45, 32
         //n = 9, n/2 --> 5

         //leftList =  10, 5
         //pivote = 15
         //rightList = 20, 35, 22, 40, 45, 32
         if (right > left)
         {
            //Case Recursive
            int pivotIndex = left + (right - left) / 2;
            pivotIndex = GetNewPivote(numbers, left, right, pivotIndex);
            QuickSort(numbers, left, pivotIndex - 1);
            QuickSort(numbers, pivotIndex + 1, right);
         }

         //Case Base
         return numbers;
      }

      protected static void WorkingWithYieldWord()
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine("Working with Yield word.");
         var names = GetNames(); //The IEnumerable is not executed until the collections is read.

         foreach (string name in GetNames())
         {
            Console.WriteLine($"Name: {name}.");
         }

         Console.WriteLine(new string('-', 50));
         foreach (string name in GetNamesByList())
         {
            Console.WriteLine($"Name: {name}.");
         }
      }

      private static IEnumerable<string> GetNames()
      {
         Random random = new Random();
         string name = string.Empty;

         for (int i = 0; i < 5; i++)
         {
            name = Names[random.Next(0, Names.Length - 1)];
            Console.WriteLine($"Using 'yield' reserved word -> {name}.");
            yield return name;
         }
      }

      private static IEnumerable<string> GetNamesByList()
      {
         List<string> namesList = new List<string>();
         Random random = new Random();
         string name = string.Empty;

         for (int i = 0; i < 5; i++)
         {
            name = Names[random.Next(0, Names.Length - 1)];
            namesList.Add(name);
            Console.WriteLine($"Common method -> {name}.");            
         }

         return namesList;
      }      
   }
}