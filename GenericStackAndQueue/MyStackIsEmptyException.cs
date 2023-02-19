using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    public class MyStackIsEmptyException : Exception {
        public MyStackIsEmptyException(String message) : base(message) {
        }
    }
}
