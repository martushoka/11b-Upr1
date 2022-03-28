using CarManager;
using NUnit.Framework;
using System;

namespace CarTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            string make = "a";
            string model = "b";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            Car car1 = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car1.Make);
            Assert.AreEqual(model, car1.Model);
            Assert.AreEqual(fuelConsumption, car1.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car1.FuelCapacity);
        }

        [Test]
        public void ModelShouldThrowArgExWhenNameIsNull()
        {
            string make = "a";
            string model = null;
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void MakeShouldThrowArgExWhenNameIsNull()
        {
            string make = null;
            string model = "b";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
        {
            string make = "a";
            string model = "b";
            double fuelConsumption = -1;
            double fuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelConsumptionShouldThrowArgExWhenIsZero()
        {
            string make = "a";
            string model = "b";
            double FuelConsumption = 0;
            double FuelCapacity = 40;

            Assert.Throws<ArgumentException>(() => new Car(make, model, FuelConsumption, FuelCapacity));
        }

        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsZero()
        {
            string make = "a";
            string model = "b";
            double FuelConsumption = 5;
            double FuelCapacity = 0;

            Assert.Throws<ArgumentException>(() => new Car(make, model, FuelConsumption, FuelCapacity));
        }

        [Test]
        public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
        {
            string make = "a";
            string model = "b";
            double FuelConsumption = 5;
            double FuelCapacity = -1;

            Assert.Throws<ArgumentException>(() => new Car(make, model, FuelConsumption, FuelCapacity));
        }

        [Test]
        [TestCase(null, "Golf", 5, 100)]
        [TestCase("Wv", null, 5, 100)]
        [TestCase("Wv", "Golf", -5, 100)]
        [TestCase("Wv", "Golf", -5, -100)]
        [TestCase("Wv", "Golf", 5, 0)]
        public void ValidateAllProperties(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }


        [Test]
        public void ShouldRefuelNormally()
        {
            string make = "a";
            string model = "b";
            double FuelConsumption = 5;
            double FuelCapacity = 40;

            Car car1 = new Car(make, model, FuelConsumption, FuelCapacity);

            car1.Refuel(10);
            Assert.AreEqual(10, car1.FuelAmount);
        }

        [Test]
        public void ShouldRefuelUntillTotalFuelCapacity()
        {
            string make = "a";
            string model = "b";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Car car1 = new Car(make, model, fuelConsumption, fuelCapacity);

            car1.Refuel(50);
            Assert.AreEqual(40, car1.FuelAmount);
        }

        [Test]
        public void ShouldRefuelThrowArgExWhenInputAmountIsBelloZero()
        {
            string make = "a";
            string model = "b";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            double inputAmount = -5;
            Car car1 = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<ArgumentException>(() => car1.Refuel(inputAmount));
        }

        [Test]
        public void ShouldDriveNormally()
        {
            Car car1 = new Car("Vw", "Golf", 2, 100);
            car1.Refuel(30);
            car1.Drive(20);
            Assert.AreEqual(29.60, car1.FuelAmount);
        }

        [Test]
        public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
        {
            Car car = new Car("Vw", "Golf", 2, 100);
            car.Refuel(0.3);
            Assert.Throws<InvalidOperationException>(() => car.Drive(20));
        }

    }
}





