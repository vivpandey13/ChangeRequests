using System;
using System.Collections.Generic;

namespace ChangeRequests
{
    public enum Operations
    {
        Add,
        Update,
        Delete
    }
    public class ChangeRequest
    {
        public List<DriverChangeRequest> DriverChangeRequests { get; set; }
        public List<VehicleChangeRequest> VehicleChangeRequests { get; set; }

    }

    public class ChangeRequestSchedule
    {
        public ChangeRequest ChangeRequest { get; set; }

        public void Submit()
        {
            ProcessDriverChangeRequest();
            ProcessVehicleChangeRequest();
        }

        // using lambda
        private void ProcessVehicleChangeRequest()
        {
            AddVehicle(ChangeRequest.VehicleChangeRequests.Find(x => x.Operation == Operations.Add)?.Vehicles);
            DeleteVehicle(ChangeRequest.VehicleChangeRequests.Find(x => x.Operation == Operations.Delete)?.Vehicles);
            UpdateVehicle(ChangeRequest.VehicleChangeRequests.Find(x => x.Operation == Operations.Update)?.Vehicles);           
            
        }

        
        // Using foreach and switch
        private void ProcessDriverChangeRequest()
        {
            foreach (var driverChangeRequest in ChangeRequest.DriverChangeRequests)
            {
                switch (driverChangeRequest.Operation)
                {
                    case Operations.Add:
                        AddDriver(driverChangeRequest.Drivers);
                        break;
                    case Operations.Delete:
                        DeleteDriver(driverChangeRequest.Drivers);
                        break;
                    case Operations.Update:
                        UpdateDriver(driverChangeRequest.Drivers);
                        break;
                    default: break;
                }
            }
        }
        #region TODO
        private void UpdateDriver(List<Driver> drivers)
        {
            
        }

        private void DeleteDriver(List<Driver> drivers)
        {
            
        }

        private void AddDriver(List<Driver> drivers)
        {
            
        }

        private void UpdateVehicle(List<Vehicle> vehicles)
        {
            
        }

        private void DeleteVehicle(List<Vehicle> vehicles)
        {
            
        }

        private void AddVehicle(List<Vehicle> vehicles)
        {
            
        }
        #endregion
    }
}