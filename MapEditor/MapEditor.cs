using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (MapGen))]

public class MapEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MapGen map = target as MapGen;

        map.GenererateMap ();
    }










}
