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
        private int topOfArray = 0;

        public MyStackArray(int arraySize) {
            ArraySize = arraySize;
            array = new T[arraySize];
        }

        public void Push(T element) {
            if (topOfArray.Equals(ArraySize)) {
                throw new MyStackIsFullException("The stack if full");
            }
            array[topOfArray++] = element;
        }

        public T Pop() {
            if (topOfArray.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            return array[topOfArray--];
        }

        public T Peek() {
            if (topOfArray.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            return array[--topOfArray];
        }
    }
}
