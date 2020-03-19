using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class MyBST<T> where T : class
    {
        private Node<T> Root;

        public void Add(int NewIndex, T NewValue)
        {
            if (Root == null)
            {
                Root = new Node<T> { Index = NewIndex, Value = NewValue };
            }
            else
            {
                var ControlNode = Root;
                while (ControlNode != null)
                {
                    if (NewIndex < ControlNode.Index)
                        ControlNode = ControlNode.LeftNode;
                    else if (NewIndex > ControlNode.Index)
                        ControlNode = ControlNode.RightNode;
                    else
                        throw new Exception($"Duplicate Index '{NewIndex}' Happened !! ");
                }
                ControlNode = new Node<T> { Index = NewIndex, Value = NewValue };
            }

        }
        public void DeleteAt(int Index)
        {

        }
        public T Search(int Index)
        {
            if (Root == null)
            {
                throw new Exception("Tree is empty");
            }
            else
            {
                var ControlNode = Root;

                while (Index != ControlNode.Index)
                {
                    if (Index < ControlNode.Index)
                        ControlNode = ControlNode.LeftNode;
                    else if (Index > ControlNode.Index)
                        ControlNode = ControlNode.RightNode;
                }
                if (ControlNode == null)
                {
                    return default(T);
                }
                else
                {
                    return ControlNode.Value;
                }
            }
        }
    }
}
