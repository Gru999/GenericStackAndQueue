using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    public interface IMyStack<T> {
        void Push(Task element);
        T Pop();
        T Peek();
    }
}
