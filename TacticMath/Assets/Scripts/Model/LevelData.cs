using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : ScriptableObject
{

    //store is the position and height of each board tile
    public List<Vector3> tiles;
    //Monster that on the tile
    public List<Point> MonstersPos;
    public List<Monster> Monsters;
    //Environment that focus real position
    public List<Environment> Environment;
    public List<Position> EnvironmentPos;
    //texture
    public Texture2D tile_texture;
}
