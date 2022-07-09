using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSFoundation.Models
{
    public class Shift
    {
        public string ShiftNumber { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is Shift shift &&
                   ShiftNumber == shift.ShiftNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ShiftNumber);
        }
        public override string ToString()
        {
            return $"Shift> ShiftNumber: {ShiftNumber}";
        }
    }
}
