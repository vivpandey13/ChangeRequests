using System;
using System.Collections.Generic;

namespace ChangeRequests
{
    public class VehicleChangeRequest: CommercialChangeRequest
    {
        public List<Vehicle> Vehicles { get; set; }        
    }
}