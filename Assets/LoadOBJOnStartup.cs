using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoadOBJOnStartup : MonoBehaviour {
    
    string[] args;
    
    void Start () {
        args = Environment.GetCommandLineArgs();
        if (args.Length > 1)
        {
            GameObject g = OBJLoader.LoadOBJFile(args[1]);
            g.transform.localScale = new Vector3(0.07f, 0.07f, 0.07f);
            g.transform.SetParent(this.transform);
        }
        else
        {
            GameObject g = OBJLoader.LoadOBJFile("GEO_Trolley0.03.obj");
            g.transform.localScale = new Vector3(0.07f, 0.07f, 0.07f);
            g.transform.SetParent(this.transform);
        }
    }

    private void OnGUI()
    {
        if (args.Length > 1)
        {
            GUI.Box(new Rect(0, 0, Screen.width, 20), args[1]);
        }
    }
}
