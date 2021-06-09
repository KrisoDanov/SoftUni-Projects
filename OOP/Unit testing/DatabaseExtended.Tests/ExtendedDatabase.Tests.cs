using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IfNameExistsThrowException()
        {
            var person = new Person(554466, "Gosho");
            var db = new ExtendedDatabase.ExtendedDatabase(person);
            var newPerson = new Person(1515, "Gosho");

            Assert.That(() => db.Add(newPerson), Throws.InvalidOperationException);
        }

        [Test]
        public void IfIdExistsThrowException()
        {
            var person = new Person(554466, "Kriso");
            var db = new ExtendedDatabase.ExtendedDatabase(person);
            var newPerson = new Person(554466, "Gosho");

            Assert.That(() => db.Add(newPerson), Throws.InvalidOperationException);
        }

        [Test]
        public void RemovingOperationIsSuccsefull()
        {
            var person = new Person(554466, "Kriso");
            var db = new ExtendedDatabase.ExtendedDatabase(person);
            db.Remove();

            var expectedInput = 0;
            var actualResult = db.Count;

            Assert.AreEqual(expectedInput, actualResult);
        }

        [Test]
        public void NoUserIsPresentByThisUsername()
        {
            var person = new Person(554466, "Kriso");
            var db = new ExtendedDatabase.ExtendedDatabase(person);
            

            var actualResult = person.UserName;

            Assert.That(() => db.FindByUsername(null), Throws.ArgumentNullException);
        }


        [Test]
        public void NoUserIsPresentByThisUsernamee()
        {
            var person = new Person(554466, "Kriso");
            var db = new ExtendedDatabase.ExtendedDatabase(person);


            var expectedInput = "Kiro";
            var actualResult = person.UserName;

            Assert.That(() => db.FindByUsername(null), Throws.ArgumentNullException);
        }
    }
}