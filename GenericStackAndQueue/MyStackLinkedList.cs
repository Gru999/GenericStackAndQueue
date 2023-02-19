using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue {
    public class MyStackLinkedList<T> : IMyStack<T> {

        private LinkedList<T> list;
        public int ListSize { get; set; }

        public MyStackLinkedList(int listSize) {
            ListSize = listSize;
            list = new LinkedList<T>();
        }


        //Action with T element as input - needs to check if the linkedlist is at max capacity
        public void Push(T element) {
            if (list.Count.Equals(ListSize)) {
                throw new MyStackIsFullException("The stack if full");
            }
            list.AddLast(element);
        }

        public T Pop() {
            if (list.Count.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            T lastNodeElement = list.Last.Value;
            list.Remove(lastNodeElement);
            return lastNodeElement;
        }

        public T Peek() { 
            if (list.Count.Equals(0)) {
                throw new MyStackIsEmptyException("The stack is empty");
            }
            return list.Last.Value;
        }
    }
}