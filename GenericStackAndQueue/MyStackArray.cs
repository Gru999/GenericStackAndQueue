using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue {
    public class MyStackArray<T> : IMyStack<T>
    {
        private T[] array;
        public int ArraySize { get; set; }
        private int _topOfArray = 0;

        public MyStackArray(int arraySize) {
            ArraySize = arraySize;
            array = new T[arraySize];
        }

        public void Push(T element) {
            if (_topOfArray.Equals(ArraySize)) {
                throw new MyStackIsFullException("The stack if full");
            }
            array[_topOfArray++] = element;
        }

        public T Pop() {
            if (_topOfArray.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            return array[_topOfArray--];
        }

        public T Peek() {
            if (_topOfArray.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            return array[--_topOfArray];
        }
    }
}
