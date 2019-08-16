using GradeBook.Classes;
using NUnit.Framework;

namespace Tests
{
    public class InMemoryBookTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_New_Instance_Name()
        {
            var bookName = "German";
            var book = new InMemoryBook(bookName);
            
            Assert.That(book, Is.Not.Null);
            Assert.That(book, Is.InstanceOf<InMemoryBook>());
            Assert.That(book.Name, Is.EqualTo(bookName));
        }
    }
}