using System;

namespace Task_1.Scripts.Menu_01
{
    public class MinuteDownButton : SpinButton
    {
        public Action ClickMinuteDownButton;
        private void OnMouseDown()
        {
            ClickMinuteDownButton?.Invoke();
        }
    }
}
