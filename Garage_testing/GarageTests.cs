﻿using Lexicon_övning5.Garage;
using Lexicon_övning5.Interface;
using Lexicon_övning5.Vehicle;

namespace Garage_testing
{
    internal class GarageTests
    {


        private Garage<IVehicle> _garage;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _garage = new Garage<IVehicle>(5); // Create a garage with a capacity of 5
        }

        [Test]
        public void AddVehicle_VehicleAddedSuccessfully_ReturnsTrue()
        {
            // Arrange
            var car = new Car("ABC123", "Red", 4, 1500, 200, "Petrol");

            // Act
            var result = _garage.AddVehicle(car);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void AddVehicle_GarageFull_ReturnsFalse()
        {
            // Arrange
            for (int i = 0; i < 5; i++)
            {
                _garage.AddVehicle(new Car($"ABC12{i}", "Red", 4, 1500, 200, "Petrol"));
            }
            var extraCar = new Car("EXTRA1", "Blue", 4, 1500, 200, "Petrol");

            // Act
            var result = _garage.AddVehicle(extraCar);

            // Assert
            Assert.IsFalse(result);
        }


    }
}
