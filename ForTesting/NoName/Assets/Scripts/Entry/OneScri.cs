using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Entry;

/// <summary> </summary>
public class OneScri : MonoBehaviour, IRunCode
{
    [SerializeField] private bool isBegan = true;
    void Awake()
    {
        
    }

    void Start()
    {
        
    }

    public void Run()
    {
        print(GetType().Name);
    }

    public bool Check()
    {
        return isBegan;
    }
}
