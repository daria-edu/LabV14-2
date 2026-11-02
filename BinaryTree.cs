using System;
using System.Collections;
using System.Collections.Generic;

public class BinaryTree<T> : IEnumerable<T>
{
    public TreeNode<T> Root;
    private IComparer<T> comparer;

    public BinaryTree()
    {
        comparer = Comparer<T>.Default;
    }

    public BinaryTree(IComparer<T> comparer)
    {
        this.comparer = comparer;
    }

    public void Add(T data)
    {
        Root = AddNode(Root, data);
    }

    private TreeNode<T> AddNode(TreeNode<T> node, T data)
    {
        if (node == null)
            return new TreeNode<T>(data);

        if (comparer.Compare(data, node.Data) < 0)
            node.Left = AddNode(node.Left, data);
        else
            node.Right = AddNode(node.Right, data);

        return node;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return PostOrder(Root).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private IEnumerable<T> PostOrder(TreeNode<T> node)
    {
        if (node == null) yield break;

        foreach (var x in PostOrder(node.Left)) yield return x;
        foreach (var x in PostOrder(node.Right)) yield return x;
        yield return node.Data;
    }
}