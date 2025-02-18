using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Entry;

/// <summary> </summary>
public class TwoScri : MonoBehaviour, IRunCode
{
    [SerializeField] private OneScri _oneScri;
    void Awake()
    {
        
    }

    void Start()
    {
        
    }
    
    public bool Run()
    {
        if (_oneScri != null)
        {
            print(GetType().Name);
            return true;
        }
        return false;
    }
}
