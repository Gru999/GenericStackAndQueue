using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    public class MyStackIsFullException : Exception {
        public MyStackIsFullException(string message) : base(message) {
        }
    }
}
