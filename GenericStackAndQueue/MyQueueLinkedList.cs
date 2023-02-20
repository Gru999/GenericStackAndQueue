using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    public class MyQueueLinkedList<T> : IMyQueue<T> {
        private LinkedList<T> list;
        public int ListSize { get; set; }
        public MyQueueLinkedList(int listSize) {
            ListSize = listSize;
            list= new LinkedList<T>();
        }

        public void Enqueue(T item) {
            if (ListSize.Equals(list.Count)) {
                throw new MyQueueIsFullException("Queue is full");
            }
            list.AddFirst(item);
        }

        public T Dequeue() {
            if (list.Count.Equals(0)) {
                throw new MyQueueIsEmptyException("Queue is empty");
            }
            T lastQueueElement = list.Last.Value;
            list.RemoveLast();
            return lastQueueElement;
        }
    }
}
