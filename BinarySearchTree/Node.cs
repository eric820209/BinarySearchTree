using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T>  where T : class
    {
        public int Index { get; set; }
        public T Value { get; set; }
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNoed { get; set; }
    }
}
