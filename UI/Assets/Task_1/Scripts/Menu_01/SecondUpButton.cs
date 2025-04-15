using System;

public class SecondUpButton : SpinButton
{
    public Action ClickSecondUpButton;
    private void OnMouseDown()
    {
        ClickSecondUpButton?.Invoke();
    }
}
