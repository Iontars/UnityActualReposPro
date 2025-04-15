using System;
using UnityEngine;

public abstract class UIPanel : MonoBehaviour
{
    private GameObject _myChild;
    public Action<GameObject> OnSelect;

    public GameObject MyChild { get; private set; }
    private void OnEnable()
    { 
        _myChild = transform.GetChild(0).gameObject;
        MyChild = _myChild;
    }
    
    private GameObject GetMyChild() => _myChild;
    
    private void OnMouseDown()
    {
        OnSelect?.Invoke(GetMyChild());
    }
}
