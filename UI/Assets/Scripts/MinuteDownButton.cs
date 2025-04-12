using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteDownButton : SpinButton
{
    public Action ClickMinuteDownButton;
    private void OnMouseDown()
    {
        ClickMinuteDownButton?.Invoke();
    }
}
