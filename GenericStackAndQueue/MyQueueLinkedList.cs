using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    public class MyQueueLinkedList<T> : IMyQueue<T> {
        private LinkedList<T> _list;
        public int ListSize { get; set; }
        public MyQueueLinkedList(int listSize) {
            ListSize = listSize;
            _list= new LinkedList<T>();
        }

        public void Enqueue(T item) {
            if (ListSize.Equals(_list.Count)) {
                throw new MyQueueIsFullException("Queue is full");
            }
            _list.AddFirst(item);
        }

        public T Dequeue() {
            if (_list.Count.Equals(0)) {
                throw new MyQueueIsEmptyException("Queue is empty");
            }
            T lastQueueElement = _list.Last.Value;
            _list.RemoveLast();
            return lastQueueElement;
        }
    }
}
