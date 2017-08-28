using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BoardCreator))]

//https://bitbucket.org/jparham/blogtacticsrpg/src/f93475123f4eea84af6039e3caea7278b37beb11/Assets/Editor/BoardCreatorInspector.cs?at=master&fileviewer=file-view-default
public class BoardCreatorInspector : Editor
{
    public BoardCreator current
    {
        get
        {
            return (BoardCreator)target;
        }
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Clear"))
            current.Clear();
        if (GUILayout.Button("Grow"))
            current.Grow();
        if (GUILayout.Button("Shrink"))
            current.Shrink();
        if (GUILayout.Button("Grow Area"))
            current.GrowArea();
        if (GUILayout.Button("Shrink Area"))
            current.ShrinkArea();
        if (GUILayout.Button("Save"))
            current.Save();
        if (GUILayout.Button("Load"))
            current.Load();

        if (GUI.changed)
            current.UpdateMarker();
    }


}
