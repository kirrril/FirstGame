using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class TestingConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine("Hello world!");

        Debug.Log("Hello people!");
        Debug.LogWarning("!! Warning !!");
        Debug.LogError("!!! ERROR !!!");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
