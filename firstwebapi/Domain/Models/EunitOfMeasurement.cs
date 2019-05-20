using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Models
{
    public enum EUnitOfMeasurement: byte
    {

        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Milligram = 1,

        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,

        [Description("L")]
        Liter = 5
    }
}
