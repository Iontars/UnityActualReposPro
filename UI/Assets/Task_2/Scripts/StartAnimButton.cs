using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimButton : MonoBehaviour
{
    public Action StartButtonPressed;
    private void OnMouseDown() => StartButtonPressed?.Invoke();
}
