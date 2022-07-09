using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSFoundation.Models
{
    public class WorkDay
    {
        public string DayNumber { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is WorkDay day &&
                   DayNumber == day.DayNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DayNumber);
        }

        public override string ToString()
        {
            return $"WorkDay> DayNumber: {DayNumber}";
        }
    }
}
