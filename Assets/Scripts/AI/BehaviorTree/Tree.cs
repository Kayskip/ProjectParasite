using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree
{
    TreeNode root = new TreeNode();

    public void addLeaf(string targetAction, string type, string action)
    {
        TreeNode node = getNodeWithAction(root, action);
        if (node == null) {
            Debug.Log("The target node does not exist. Try 'root' if it is new.");
            return;
        }
        TreeNode child = new TreeNode();
        child.setType(type);
        child.setAction(action);
        child.getChildren();
        child.setParentNode(node);
        node.addChild(child);
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

    public List<string> getActionsUnderNode(string action){
        List<string> ActionList = new List<string>();
        TreeNode node = getNodeWithAction(root, action);
        if (node == null)
        {
            Debug.Log("The target node does not exist. Try other action name.");
            return ActionList;
        }
        foreach (TreeNode n in node.getChildren())
        {
            ActionList.Add(n.getAction());
        }
        return ActionList;
    }

    public void removeNode(string action) {
        TreeNode node = getNodeWithAction(root, action);
        if (node == null)
        {
            Debug.Log("The target node does not exist. Does not remove anything.");
            return;
        }
        TreeNode parentNode = node.getParentNode();
        parentNode.removeChild(node);
    }

}