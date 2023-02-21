using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue {
    public class MyStackLinkedList<T> : IMyStack<T> {

        private LinkedList<T> _list;
        public int ListSize { get; set; }

        public MyStackLinkedList(int listSize) {
            ListSize = listSize;
            _list = new LinkedList<T>();
        }


        //Action with T element as input - needs to check if the linkedlist is at max capacity
        public void Push(T element) {
            if (_list.Count.Equals(ListSize)) {
                throw new MyStackIsFullException("The stack if full");
            }
            _list.AddLast(element);
        }

        public T Pop() {
            if (_list.Count.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            _list.Remove(_list.Last.Value);
            return _list.Last.Value;
        }

        public T Peek() { 
            if (_list.Count.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            return _list.Last.Value;
        }
    }
}