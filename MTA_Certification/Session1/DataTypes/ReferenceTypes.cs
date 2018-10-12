namespace Session1.DataTypes
{
    /// <summary>
    /// Doesn't contains data value instead It contains memory address reference where the value is stored.
    /// These are stored on HEAP.
    /// </summary>
    public class ReferenceTypes
    {        
        #region Class
        /// All element that inherit of "object" class and also all structures created by user.
        /// <summary>
        /// String of characters.
        /// </summary>
        public string StringType { get; set; }

        /// <summary>
        /// All structures created by User
        /// </summary>
        public ClassType ClassType { get; set; }
        #endregion

        #region Delegates
        /// <summary>
        /// These are special object that encapsulates a method reference through specific signature.
        /// </summary>
        /// <param name="text"></param>
        public delegate void DelegateType(string text);
        #endregion

        #region Interfaces
        /// <summary>
        /// Interface is a element that allow the abstraction of fields and methods (CONTRACT)
        /// </summary>
        public interface IIntefaceType
        {
            void GetTitle();
        }
        #endregion

        #region Uni-Bi Dimensional Arrays        
        public string[] UnidimensionalArray { get; set; }
        public string[][] BidimensionalArray { get; set; } 
        #endregion
    }

    /// <summary>
    /// Class defined by user, whatever structure created by USER.
    /// </summary>
    public class ClassType { }
}