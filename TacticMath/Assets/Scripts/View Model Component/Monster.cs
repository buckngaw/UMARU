using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Monster : ScriptableObject
{
     
    public GameObject model;  //model in here
    public float height; // height mon stand on
    public int size; //size monster

    /*void Intitial()
    {
        transform.localPosition = new Vector3(pos.x, height, pos.y);
        transform.localScale = new Vector3(size,size,size);
    }*/



}
