using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellSet : MonoBehaviour
{
    enum MyEnum
    {
        
    }
    
    [SerializeField][Range(-1000f, 1000f)] private float _x;
    [SerializeField][Range(-1000f, 1000f)] private float _y;
    private Vector2 _position;

    private void OnValidate()
    {
        AssignPosition(_position);
    }

    private void AssignPosition(Vector2 position)
    {
        position = new Vector2(_x * 0.01f, _y * 0.01f);
        transform.position = position;
    }

}
