using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constrictor_Should_Contain_16_Elements()
        {
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            Database.Database databse = new Database.Database(numbers);

            var expectedResult = 16;
            var actualResult = databse.Count;
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Constrictor_Should_Not_Contain_MoreTnah_16_Elements()
        {
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Database.Database databse = new Database.Database(numbers);

            var expectedResult = 10;
            var actualResult = databse.Count;
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void AddOperationSholudAddElementAtTheNextFreeCell()
        {
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Database.Database databse = new Database.Database(numbers);
            databse.Add(5);

            var allElements = databse.Fetch();
            var expectedValue = 5;
            var realValue = allElements[10];

            Assert.AreEqual(expectedValue, realValue);

        }
        [Test]
        public void AddOperationShouldContainsOnly16ElemetsOrThrowException()
        {
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            Database.Database databse = new Database.Database(numbers);

            Assert.Throws<InvalidOperationException>(() => databse.Add(10));
        }
        [Test]
        public void RemoveOperationShioldSupportRemovingElementAtlastIndex()
        {
            int[] numbers = Enumerable.Range(1, 11).ToArray();
            Database.Database databse = new Database.Database(numbers);
            databse.Remove();

            
            var expectedValue = 10;
            var realValue = databse.Count;

            Assert.AreEqual(expectedValue, realValue);

        }
        [Test]
        public void RemoveOperationShiolThrowExceptionIfDatabaseIsEmpty()
        {
            
            Database.Database databse = new Database.Database();

            Assert.Throws<InvalidOperationException>(() => databse.Remove());
        }

        [Test]
        public void FetchShouldRetrunAllElements()
        {
            int[] nums = Enumerable.Range(1, 5).ToArray();
            Database.Database database = new Database.Database(nums);

            var allItems = database.Fetch();

            int[] expectedValue = { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(expectedValue, allItems);
        }


    }
}