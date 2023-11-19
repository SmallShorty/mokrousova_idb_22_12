using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUICounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int Counter = 0;

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 100, 100));

        GUILayout.Label("counter: " + Counter);

        GUILayout.EndArea();
    }
}
