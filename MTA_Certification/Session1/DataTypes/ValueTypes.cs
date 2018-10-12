namespace Session1.DataTypes
{
   /// <summary>
   /// Contain directly data, these are stored on Global Static or Stack Memory
   /// Only can modify through operands "out" or "ref".
   /// </summary>
   public class ValueTypes
   {
      #region Simple
      /// <summary>
      /// 2 bytes -- 16 bits (Characters Unicode) U+0000 - U+ffff 
      /// </summary>
      public char CharType { get; set; }

      /// <summary>
      /// 2 bytes -- 16 bits (true or false)
      /// </summary>
      public bool BooleanType { get; set; }

      /// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
      /// INT OR NUMBER (with sign or without sign)
      /// <summary>
      /// 1 byte -- 8 bits (0-255)
      /// </summary>
      public byte ByteType { get; set; }

      /// <summary>
      /// 2 bytes -- 16 bits (2^16 -/+)
      /// </summary>
      public short ShortType { get; set; }

      /// <summary>
      /// 4 bytes -- 32 bits (2^32 -/+)
      /// </summary>
      public int IntType { get; set; }

      /// <summary>
      /// 8 bytes -- 64 bits (2^64 -/+)
      /// </summary>
      public long LongType { get; set; }
      /// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --


      /// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
      /// Float point
      /// <summary>
      /// 4 bytes -- 32 bits (2^32 -/+) --- Precision [0, 7]
      /// </summary>
      public float FloatType { get; set; }

      /// <summary>
      /// 8 bytes -- 64 bits (2^64 -/+) --- Precision [15 - 16]
      /// </summary>
      public double DoubleType { get; set; }
      /// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

      /// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
      /// Decimal of High Precision
      /// <summary>
      /// 16 bytes -- 128 bits (2^128 -/+) --- Precision [28 - 29]
      /// </summary>
      public decimal DecimalType { get; set; }
      /// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
      #endregion

      #region Enumerations
      public enum EnumerationType : byte
      {
         Value1 = 1,
         Value2 = 2,
         Value3 = 3
      }
      #endregion

      #region Structs
      /// <summary>
      /// Similar to CLASS but an element can not inherit from "STRUCTS"
      /// Doesn't allow inherit.
      /// </summary>
      public struct Person
      {
         //Properties
         public byte Age { get; set; }
         public float Weight;
         public string Name;

         //Constructor
         public Person(byte age, float weight, string name)
         {
            Age = age;
            Weight = weight;
            Name = name;
         }
      }
      #endregion

      #region NULLs
      public int? IntNullType { get; set; }
      #endregion
   }
}