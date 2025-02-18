using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Entry;

/// <summary> </summary>
public class EntryPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> _runObjects;
    private List<IRunCode> _runCodes = new();
    void Start()
    {
        

        Activate();
    }

    private void Activate()
    {
        foreach (var t in _runObjects)
        {
            _runCodes.Add(t.GetComponent<IRunCode>());
        }
        
        foreach (var t in _runCodes)
        {
            if (!t.Run())
            {
                ErrorData.LogError(1);
                break;
            }
        }
    }
}
