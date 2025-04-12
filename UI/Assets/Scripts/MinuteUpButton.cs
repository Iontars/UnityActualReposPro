using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteUpButton : SpinButton
{
    public Action ClickMinuteUpButton;
    private void OnMouseDown()
    {
        ClickMinuteUpButton?.Invoke();
    }
}
