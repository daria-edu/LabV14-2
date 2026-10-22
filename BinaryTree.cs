using System;
using System.Collections;
using System.Collections.Generic;

public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
{
    public TreeNode<T> Root; 

   
    public void Add(T data)
    {
        if (Root == null)
        {
            Root = new TreeNode<T>(data);
            return;
        }

        TreeNode<T> current = Root;
        while (true)
        {
            if (data.CompareTo(current.Data) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = new TreeNode<T>(data);
                    break;
                }
                current = current.Left;
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new TreeNode<T>(data);
                    break;
                }
                current = current.Right;
            }
        }
    }

    
    public IEnumerator<T> GetEnumerator()
    {
        List<T> list = new List<T>();
        PostOrder(Root, list);
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    
    private void PostOrder(TreeNode<T> node, List<T> list)
    {
        if (node == null) return;

        PostOrder(node.Left, list);   
        PostOrder(node.Right, list);  
        list.Add(node.Data);          
    }
}