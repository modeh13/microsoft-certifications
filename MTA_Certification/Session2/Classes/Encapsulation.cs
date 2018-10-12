using System;

namespace Session2.Classes
{
   //By default, if we don't define the access modifier to the Class, It will be "internal"
   //The Classes of most high level into "namespaces" must be "public or internal"
   class Encapsulation
   {
      public string name = ""; //It is visible for all classes and assemblies.
      protected string lastName = ""; //It is visible only for the subclasses or derived class.
      private byte age = 0; //It is visible only for the owner class.
      internal DateTime birthDay; //It is visible only for the all class in the same assembly.
      protected internal byte id; //It means "protected OR internal" (any class in the same assembly, or any derived class even if it is in a different assembly).      
   }

   public class FirstLevel
   {
      public class SecondLevelA { }
      private class SecondLevelB { }
      protected class SecondLevelC { }
      internal class SecondLevelD { }
      protected internal class SecondLevelE { }
      //private protected class SecondLevelF { } //Only in C# 7.2 or greater. 
      //Access is limited to the containing class or types derived from the containing class within the "current assembly".
   }
}