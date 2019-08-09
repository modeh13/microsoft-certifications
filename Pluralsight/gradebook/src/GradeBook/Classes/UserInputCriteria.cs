using System;

namespace GradeBook.Classes
{
    public sealed class UserInputCriteria
    {        
        /// <summary>
        /// Gets o sets the dataType like string, int, double, float, and so forth.
        /// </summary>
        /// <value></value>
        public Type DataType { get; set; }

        /// <summary>
        /// Gets o sets all allowed values that user can entry in Console.Input.
        /// </summary>
        /// <value></value>
        public string[] Values { get; set; } = {};
    }
}