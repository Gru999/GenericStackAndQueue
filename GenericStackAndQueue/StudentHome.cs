using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    class StudentHome : Person {
        public int ParentIncome { get; set; }

        public StudentHome(int parentIncome, string name, int age) : base(name, age) {
            ParentIncome = parentIncome;
        }

        public override int CalculateSUPrMonth() {
            if (Age >= 20) {
                return ParentIncome > 600000 ? 1013 : 2725 ;
            }
            return 3143;
        }

        public override string ToString() {
            return base.ToString() + $"ParentIncome {ParentIncome}, SU: {CalculateSUPrMonth()}Kr";
        }
    }
}
