using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StartUpScript : MonoBehaviour
{

    public Camera Camera1;    
    void Awake()
    {
        Color[] backgrounds = {Color.red, Color.green, Color.blue, Color.black};

        Color SetBackground = backgrounds[Random.Range(0, backgrounds.Length -1)];
        
        Camera1.backgroundColor = SetBackground;
    }
}


