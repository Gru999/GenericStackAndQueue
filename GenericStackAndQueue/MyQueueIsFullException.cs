using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    public class MyQueueIsFullException : Exception {
        public MyQueueIsFullException(string message) : base(message) {
        }
    }
}
