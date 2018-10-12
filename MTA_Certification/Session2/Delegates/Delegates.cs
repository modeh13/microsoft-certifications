using System;

namespace Session2.Delegates
{
   public delegate void DelegateText(string text);

   public class Delegates
   {
      public delegate void SetText(string text);
      public delegate int GetSum(int a, int b);
   }   
}