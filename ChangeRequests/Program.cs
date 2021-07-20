using System.Collections.Generic;

namespace ChangeRequests
{
    class Program
    {
        static void Main(string[] args)
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
                Vehicles = new List<Vehicle>{ vehicle}
            };
            var changeRequest = new ChangeRequest
            {
                DriverChangeRequests =new List<DriverChangeRequest>{ driverChangeRequest },
                VehicleChangeRequests = new List<VehicleChangeRequest>{ vehicleChangeRequest }
            };
            var changeRequestSchedule = new ChangeRequestSchedule
            {
                ChangeRequest = changeRequest
            };

            changeRequestSchedule.Submit();
        }
    }
}
