using System;

namespace Task_1.Scripts.Menu_01
{
    public class MinuteUpButton : SpinButton
    {
        public Action ClickMinuteUpButton;
        private void OnMouseDown()
        {
            ClickMinuteUpButton?.Invoke();
        }
    }
}
