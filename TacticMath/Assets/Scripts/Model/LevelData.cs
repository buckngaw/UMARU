using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : ScriptableObject
{

    //store is the position and height of each board tile
    public List<Vector3> tiles;
    //Monster
    public List<Point> MonstersPos;
    public List<Monster> Monsters;
    //texture
    public Texture2D tile_texture;
}
