using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondUpButton : SpinButton
{
    public Action ClickSecondUpButton;
    private void OnMouseDown()
    {
        ClickSecondUpButton?.Invoke();
    }
}
