using System;

namespace Task_1.Scripts.Menu_01
{
    public class SecondUpButton : SpinButton
    {
        public Action ClickSecondUpButton;
        private void OnMouseDown()
        {
            ClickSecondUpButton?.Invoke();
        }
    }
}
