using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Load Environment in map
public class Board : MonoBehaviour {
    //can load our LevelData and create a game board level at run-time
    [SerializeField] GameObject tilePrefab;
    [SerializeField] GameObject MonPrefab;

    public Dictionary<Point, Tile> tiles = new Dictionary<Point, Tile>();

    public void LoadData(LevelData data)
    {
        for (int i = 0; i < data.tiles.Count; ++i)
        {
            GameObject instance = Instantiate(tilePrefab) as GameObject;
            Tile t = instance.GetComponent<Tile>();
            t.Load(data.tiles[i]);
            tiles.Add(t.pos, t);
        }
    }
    public void LoadMon(LevelData data)
    {
        for (int i = 0; i < data.Monsters.Count; ++i)
        {
            Point pos = data.MonstersPos[i];
            GameObject instance = Instantiate(data.Monsters[i].model) as GameObject; //position that mon stand
            instance.transform.localPosition = new Vector3(pos.x, data.Monsters[i].height, pos.y);
            instance.transform.localScale = new Vector3(data.Monsters[i].size, data.Monsters[i].size, data.Monsters[i].size);
            instance.transform.rotation = Quaternion.Euler(0, 180, 0);

        }
          
        //Debug.Log("eiei");
    }
}
