using System;

public class MinuteDownButton : SpinButton
{
    public Action ClickMinuteDownButton;
    private void OnMouseDown()
    {
        ClickMinuteDownButton?.Invoke();
    }
}
