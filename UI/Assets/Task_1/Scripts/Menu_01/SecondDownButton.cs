using System;

public class SecondDownButton : SpinButton
{
    public Action ClickSecondDownButton;
    private void OnMouseDown()
    {
        ClickSecondDownButton?.Invoke();
    }
}
