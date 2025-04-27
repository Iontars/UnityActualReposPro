using System;

namespace Task_1.Scripts.Menu_01
{
    public class SecondDownButton : SpinButton
    {
        public Action ClickSecondDownButton;
        private void OnMouseDown()
        {
            ClickSecondDownButton?.Invoke();
        }
    }
}
