using System.Collections.Generic;

namespace ChangeRequests
{
    public class DriverChangeRequest: CommercialChangeRequest
    {
        public List<Driver> Drivers { get; set; }        
    }
}