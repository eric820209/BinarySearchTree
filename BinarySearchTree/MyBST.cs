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
                if (NewIndex < Root.Index)//新數字小要放左邊
                {
                   
                    if (Root.LeftNode == null)
                    {
                        Root.LeftNode = new Node<T> { Index = NewIndex, Value = NewValue };
                    }
                    else
                    {
                        GoNextStage(Root.LeftNode,NewIndex,NewValue);
                    }
                }
                else if (NewIndex > Root.Index)//新數字大要放右邊
                {
                    
                    if (Root.RightNode == null)
                    {
                        Root.RightNode = new Node<T> { Index = NewIndex, Value = NewValue };
                    }
                    else
                    {
                        GoNextStage(Root.RightNode, NewIndex, NewValue);
                    }

                }
                else
                {
                    throw new Exception($"Duplicate Index '{NewIndex}' Happened !! ");
                }
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
                    if (ControlNode == null)
                    { 
                    
                    }
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

        private void GoNextStage(Node<T> NowNode,int NewIndex ,T NewValue)
        {
            if (NewIndex < NowNode.Index)
            {
                if (NowNode.LeftNode == null)
                {
                    NowNode.LeftNode = new Node<T> { Index = NewIndex, Value = NewValue };
                }
                else if(NowNode.LeftNode.Index==NewIndex)
                {
                    throw new Exception($"Duplicate Index '{NewIndex}' Happened !! ");
                }
                else
                {
                    GoNextStage(NowNode.LeftNode, NewIndex, NewValue);
                }

            }
            else
            {
                if (NowNode.RightNode == null)
                {
                    NowNode.RightNode = new Node<T> { Index = NewIndex, Value = NewValue };
                }
                else if (NowNode.RightNode.Index == NewIndex)
                {
                    throw new Exception($"Duplicate Index '{NewIndex}' Happened !! ");
                }
                else
                {
                    GoNextStage(NowNode.RightNode, NewIndex, NewValue);
                }
            }
        }
    }
}
