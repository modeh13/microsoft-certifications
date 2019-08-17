using System;

namespace GameConsole.Classes
{
    class PlayerCharacterNullable
    {
        public string Name { get; set; }

        // Long way to define a nullable value type.        
        public Nullable<int> DaysSinceLastLogin { get; set; }

        // Shorthand (using question mark) to define a nullable value type.
        public DateTime? DateOfBirth { get; set; }

        // Default value for a Nullable variable will be null.
        public bool? IsNoob { get; set; }

        public PlayerCharacterNullable()
        {            
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }

        //Nullable<T>
        // Properties
        // .HasValue: false if null, true if valid value.
        // .Value: gets underlying value, throws an exception (InvalidOperationException) if value is null.
        // Methods
        // .GetValueOrDefault(): gets underlying value of default value based on data type (int -> 0, so on).
        // .GetValueOrDefault(default): gets underlying value or returs value supplied as parameter.
        //
        // Explicit conversion
        // from Nullable<T> to T
        // int? i = 42;
        // int j = i; // It will throw an InvalidCastException.
        // The above happens because it could potentially be losing data.
        // int j = (int) i;

        // C# Operators
        // Null-coalescing operator: ??
        // Null-Conditional operator: .? -- Working with arrays: ?[
    }
}