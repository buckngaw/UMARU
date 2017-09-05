using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public const float stepHeight = 0.25f;
    //track its own position and height
    public Point pos;
    public int height;

    //place other objects in the center of the top of the tile
    public Vector3 center { get { return new Vector3(pos.x, height * stepHeight, pos.y); } }

    //the position or height of a tile is modified, I will want it to be able to visually reflect its new values
    void Match()
    {
        transform.localPosition = new Vector3(pos.x, height * stepHeight / 2f, pos.y);
        transform.localScale = new Vector3(1, height * stepHeight, 1);
    }

    //create the boards by randomly growning and or shrinking tiles
    public void Grow()
    {
        height++;
        Match();
    }
    //easy for me to persist the Tile data as a Vector3 later.
    public void Shrink()
    {
        height--;
        Match();
    }

    public void Load(Point p, int h)
    {
        pos = p;
        height = h;
        Match();
    }
    public void Load(Vector3 v)
    {
        Load(new Point((int)v.x, (int)v.z), (int)v.y);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
