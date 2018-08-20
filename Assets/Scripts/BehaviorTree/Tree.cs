using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree
{
    TreeNode root = new TreeNode();

    public void addLeaf(string target, string type, string action)
    {
        TreeNode node = root;
        TreeNode child = new TreeNode();
        child.setType(type);
        child.setAction(action);
        child.getChildren();
    }

    public TreeNode getNodeWithAction(TreeNode node, string action)
    {
        foreach (TreeNode n in node.getChildren())
        {
            if (n.getAction().Equals(action))
            {
                return n;
            }
            else
            {
                getNodeWithAction(n, action);
            }
        }
        return null;
    }
}