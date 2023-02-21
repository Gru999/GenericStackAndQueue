using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenericStackAndQueue {
    public class MyQueueArray<T> : IMyQueue<T> {
        private T[] array;
        private int _topOfArray = 0;
        private int _bottomOfArray = 0;
        private int _count = 0;

        public MyQueueArray(int size) {
            array = new T[size];
        }

        //might be a problem with enumaration and index reset
        public void Enqueue(T item) {
            if (_count.Equals(array.Count())) {
                throw new MyQueueIsFullException("Queue is full");
            }
            array[_bottomOfArray++] = item;
            _count++;
        }

        public T Dequeue() {
            if (_count.Equals(0)) {
                throw new MyQueueIsEmptyException("Queue is empty");
            }
            T topQueueItem = array[_topOfArray++];
            _count--;
            return topQueueItem;
        }
    }
}
