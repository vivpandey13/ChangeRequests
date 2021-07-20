using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeRequests.Tests
{
    [TestClass()]
    public class ChangeRequestScheduleTests
    {
        public ChangeRequestSchedule ChangeRequestSchedule { get; set; }
        public ChangeRequestScheduleTests()
        {
            Driver driver = new()
            {
                FirstName = "Test"
            };
            Vehicle vehicle = new()
            {
                VIN = "Test"
            };
            DriverChangeRequest driverChangeRequest = new()
            {
                Drivers = new List<Driver> { driver },
                Operation = Operations.Add
            };
            VehicleChangeRequest vehicleChangeRequest = new()
            {
                Operation = Operations.Add,
                Vehicles = new List<Vehicle> { vehicle }
            };
            var changeRequest = new ChangeRequest
            {
                DriverChangeRequests = new List<DriverChangeRequest> { driverChangeRequest },
                VehicleChangeRequests = new List<VehicleChangeRequest> { vehicleChangeRequest }
            };
            ChangeRequestSchedule = new ChangeRequestSchedule { ChangeRequest = changeRequest };
                       
        }
        [TestMethod()]
        public void SubmitTest()
        {
            Assert.IsTrue(ChangeRequestSchedule.Submit());            
        }
    }
}