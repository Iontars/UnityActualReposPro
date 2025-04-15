using System;

public class MinuteUpButton : SpinButton
{
    public Action ClickMinuteUpButton;
    private void OnMouseDown()
    {
        ClickMinuteUpButton?.Invoke();
    }
}
