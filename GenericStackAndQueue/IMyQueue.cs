﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue {
    public interface IMyQueue<T> {
        void Enqueue(T item);
        T Dequeue();
    }
}
