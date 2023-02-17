using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    class StudentOut : Person {

        public StudentOut(string name, int age) : base(name, age) {
        }

        public override int CalculateSUPrMonth() {
            return Age >= 18 ? 6321 : 4055; ;
        }
        public override string ToString() {
            return base.ToString() + $"SU: {CalculateSUPrMonth()}Kr";
        }
    }
}
