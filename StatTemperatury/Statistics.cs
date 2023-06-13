using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StatTemperatury
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Count { get; private set; }
        public float average 
        {
            get
            {
                return this.Sum / this.Count;
            }    
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddTemp(float temp)
        {
            this.Count++;
            this.Sum += temp;
            this.Min = Math.Min(temp, this.Min);
            this.Max = Math.Max(temp, this.Max);
        }
    }
}
