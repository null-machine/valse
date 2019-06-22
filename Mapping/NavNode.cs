using UnityEngine;
using System.Collections.Generic;

public class NavNode {

// nav map?

  public Vector2 pos;
  public Dictionary<NavNode, float> links;
  
  public NavNode(Vector2 pos) {
    this.pos = pos;
    links = new Dictionary<NavNode, float>();
  }
  
  public void Link(NavNode node) {
    float dist = (pos - node.pos).magnitude;
    links.Add(node, dist);
    node.links.Add(this, dist);
  }
  
  public void Unlink(NavNode node) {
    links.Remove(node);
    node.links.Remove(this);
  }
}
