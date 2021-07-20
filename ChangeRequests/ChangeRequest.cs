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

        private void ProcessVehicleChangeRequest()
        {
            AddVehicle(ChangeRequest.VehicleChangeRequests.Find(x => x.Operation == Operations.Add).Vehicles);
            DeleteVehicle(ChangeRequest.VehicleChangeRequests.Find(x => x.Operation == Operations.Delete).Vehicles);
            UpdateVehicle(ChangeRequest.VehicleChangeRequests.Find(x => x.Operation == Operations.Update).Vehicles);           
            
        }

        

        private void ProcessDriverChangeRequest()
        {
            foreach (var driverChangeRequest in ChangeRequest.DriverChangeRequests)
            {
                switch (driverChangeRequest.Operation)
                {
                    case Operations.Add: AddDriver(driverChangeRequest.Drivers);
                        break;
                    case Operations.Delete: DeleteDriver(driverChangeRequest.Drivers);
                        break;
                    case Operations.Update: UpdateDriver(driverChangeRequest.Drivers);
                        break;
                    default: break;
                }
            }
        }
        #region TODO
        private void UpdateDriver(List<Driver> drivers)
        {
            throw new NotImplementedException();
        }

        private void DeleteDriver(List<Driver> drivers)
        {
            throw new NotImplementedException();
        }

        private void AddDriver(List<Driver> drivers)
        {
            throw new NotImplementedException();
        }

        private void UpdateVehicle(List<Vehicle> vehicles)
        {
            throw new NotImplementedException();
        }

        private void DeleteVehicle(List<Vehicle> vehicles)
        {
            throw new NotImplementedException();
        }

        private void AddVehicle(List<Vehicle> vehicles)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}