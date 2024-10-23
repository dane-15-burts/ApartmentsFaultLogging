using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HabitatApartmentsFaultLogging.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string UnitNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}