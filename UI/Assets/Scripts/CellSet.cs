using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellSet : MonoBehaviour
{
    enum MyEnum
    {
        
    }
    
    [SerializeField][Range(-10.000f, 10.000f)] private float _x;
    [SerializeField][Range(-10f, 10f)] private float _y;
    private Vector2 _position;

    private void OnValidate()
    {
        AssingPosition(_position);
    }

    private void AssingPosition(Vector2 position)
    {
        position = new Vector2(_x, _y);
        transform.position = position;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
