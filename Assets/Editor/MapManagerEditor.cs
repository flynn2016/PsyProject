using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapManager))]
public class MapManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapManager myScript = (MapManager)target;
        if(GUILayout.Button("Delete Map"))
        {
            myScript.DeleteMap();
        }

        if (GUILayout.Button("Generate Map"))
        {
            myScript.GenerateMap();
        }
    }
}
