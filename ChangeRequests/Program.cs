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
                Drivers = { driver },
                Operation = Operations.Add
            };
            VehicleChangeRequest vehicleChangeRequest = new()
            {
                Operation = Operations.Add,
                Vehicles = { vehicle}
            };
            var changeRequest = new ChangeRequest
            {
                DriverChanngeRequests = { driverChangeRequest },
                VehicleChangeRequests = { vehicleChangeRequest }
            };
            var changeRequestSchedule = new ChangeRequestSchedule
            {
                ChangeRequest = changeRequest
            };

            changeRequestSchedule.Submit();
        }
    }
}
