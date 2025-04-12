using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDownButton : SpinButton
{
    public Action ClickSecondDownButton;
    private void OnMouseDown()
    {
        ClickSecondDownButton?.Invoke();
    }
}
