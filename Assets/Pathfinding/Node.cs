using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Node // This is a C# pure class, not derived from MonoBehavior, and cannot be attatched to obejcts.
{
    public Vector2Int coordinates; 
    public bool isWalkable;
    public bool isExplored;
    public bool isPath;
    public Node connectedTo;

    // This is a "constructor". Similar to a method in a C# pure class, the name of the constuctor is derived from the class name.
    public Node(Vector2Int coordinates, bool isWalkable)
    {
        this.coordinates = coordinates;
        this.isWalkable = isWalkable;
    }
}
