using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeNode {

    public string nodeType = "selector";
    public string action = "root";
    public List<TreeNode> childrenList = new List<TreeNode>();

    public void setType(string nodeType)
    {
        if (nodeType.Equals("mono"))
        {
            this.nodeType = "mono";
        }
        else if (nodeType.Equals("sequence"))
        {
            this.nodeType = "sequence";
        }
        else if (nodeType.Equals("selector"))
        {
            this.nodeType = "selector";
        }
        else
        {
            this.nodeType = "leaf";
        }
    }

    public void setAction(string action)
    {
        this.action = action;
    }

    public void addChild(TreeNode node) {
        if (nodeType.Equals("mono") && childrenList.Count > 1) {
            // if it is the case of mono and number of leaves are more than 1 then do nothing 
        }
        else {
            childrenList.Add(node);
        }
    }

    public void removeChild(TreeNode node) {
        childrenList.Remove(node);
    }

    public string getAction() {
        return action;
    }

    public string getType() {
        return nodeType;
    }

    public List<TreeNode> getChildren() {
            return childrenList;
    }
}
