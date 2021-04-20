using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbing.classes
{
    public class Individual
    {
        public int Id { get; set; }
        public double Xreal { get; set; }
        public int Xint { get; set; }
        public string Xbit { get; set; }
        public double Fx { get; set; }
        public double P { get; set; }

        public Individual Clone()
        {
            return (Individual)this.MemberwiseClone();
        }
    }
}
