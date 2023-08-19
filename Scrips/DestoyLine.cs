using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyLine : MonoBehaviour
{
    
    
    public void ClearLine()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Line");
        foreach (var line in gameObjects)
        {
            Destroy(line);
        }
    }
}
