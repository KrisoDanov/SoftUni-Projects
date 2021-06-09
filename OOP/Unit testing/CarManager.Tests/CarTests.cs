using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Ford", "Escort", 8, 50)]
        public void CarConstructorWorksProperly(string make
            , string model
            , double consumption,
            double fuelCapacity)
        {
            Car car = new Car(make: make,
                model: model,
                fuelConsumption: consumption,
                fuelCapacity: fuelCapacity);

            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, consumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
            Assert.AreEqual(car.FuelAmount, 0);
        }

        [Test]
        public void tryRefuelMethodWithMinusNumber()
        {
            Car car = new Car("Ford", "Escort", 8, 50);

            var refueling = -5;

            Assert.Throws<ArgumentException>(() => car.Refuel(refueling));
        }

        [Test]
        public void RefuelingCarWithGoodGas()
        {
            Car car = new Car("Ford", "Escort", 8, 50);

            car.Refuel(15);

            var expectedOutpu = 15;
            var RealOutput = car.FuelAmount;

            Assert.AreEqual(expectedOutpu, RealOutput);
        }

        [Test]
        public void CarDriveExceptionWithMoreKmThanFuel()
        {
            Car car = new Car("Ford", "Escort", 10, 100);
            car.Refuel(50);

            Assert.Throws<InvalidOperationException>(() => car.Drive(505));
        }

        [Test]
        public void WhenDriveFuelAmountGetsLower()
        {
            Car car = new Car("Ford", "Escort", 10, 100);
            car.Refuel(100);
            car.Drive(50);

            var expectedOutpu = 95;
            var Realoutput = car.FuelAmount;
            Assert.AreEqual(expectedOutpu, Realoutput);
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CarMakeIsNotNullOrEmtyString(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make: make, "sasc", 10, 100));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CarModelIsNotNullOrEmtyString(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("sasc",model: model, 10, 100));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void CarFuelConsumptionIsNotZeroOrNegative(double fuelConsmp)
        {
            Assert.Throws<ArgumentException>(() => new Car("Ford", "sasc", fuelConsmp, 100));
        }

        [Test]
        
        [TestCase(-5)]
        public void CarFuelAmountIsNotNegative(double fuelConsmp)
        {
            Assert.Throws<ArgumentException>(() => new Car("Ford", "sasc", 10, fuelConsmp));
        }
    }
}